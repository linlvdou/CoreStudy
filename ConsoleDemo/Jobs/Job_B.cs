using FluentScheduler;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ConsoleDemo.Jobs
{
    public class Job_B : IJob
    {
        void IJob.Execute()
        {
            var msg = ">>开始执行【Job_B】，当前时间是：" + DateTime.Now;
            Trace.WriteLine(msg);
            Console.WriteLine(msg);
        }
    }
}
