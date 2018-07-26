using ConsoleDemo.Models;
using ConsoleTables;
using System.Collections.Generic;
using System.Drawing;
using Console = Colorful.Console;
using FluentScheduler;
using ConsoleDemo.Jobs;
using Microsoft.Extensions.DependencyInjection;
using System;
using ConsoleDemo.Interface;

namespace ConsoleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = ".Net Core Console Demo";
            DependencyInjection();
            Console.ForegroundColor = Color.GreenYellow;

            PrintTableMenu();

            //
            OrderSettlement.DoSettlement();

            //任务调度实例
            JobManager.Initialize(new JobFactory());
            
            Console.ReadKey();

        }

        /// <summary>
        /// 打印控制台表单实例
        /// </summary>
        static void PrintTableMenu()
        {
            var table = new ConsoleTable("编号", "功能", "描述");
            var options = new List<Option>() {
                new Option{ ID = 1, Ttile = "控制台打印表格实例" },
                new Option{ ID = 2, Ttile = "控制台文本样式实例" }
            };
            foreach (var item in options)
            {
                table.AddRow(item.ID, item.Ttile, item.Description);
            }
            //table.Options.EnableCount = false;
            table.Write();
            //ConsoleTable.From<Option>(options).Write();
        }

        /// <summary>
        /// 控制台注入实例
        /// </summary>
        static void DependencyInjection()
        {
            IServiceCollection services = new ServiceCollection();
            services.AddTransient<NoReturn>();
            services.AddTransient<Normal>();
            services.AddScoped<FullReturn>();

            var provider = services.BuildServiceProvider();

            var noReturn = provider.GetService<NoReturn>();
            Console.WriteLine(noReturn.GetBusinessName());
            var normal = provider.GetService<Normal>();
            Console.WriteLine(normal.GetBusinessName());
            var fullReturn = provider.GetService<FullReturn>();
            Console.WriteLine(fullReturn.GetBusinessName());
        }
    }
}
