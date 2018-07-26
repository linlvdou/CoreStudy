using FluentScheduler;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace ConsoleDemo.Jobs
{
    public class Job_A : IJob
    {
        void IJob.Execute()
        {
            Console.WriteLine("=================================================");
            var msg = ">>开始执行【Job_A】，当前时间是：" + DateTime.Now;
            Trace.WriteLine(msg);
            Console.WriteLine(msg);
            Thread.Sleep(3000);
            Trace.WriteLine(">>【Job_A】执行完成...");
            
        }
    }
}
