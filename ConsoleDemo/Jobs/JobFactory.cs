using FluentScheduler;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDemo.Jobs
{
    public class JobFactory : Registry
    {
        public JobFactory()
        {
            Schedule<Job_A>().AndThen<Job_B>().ToRunNow().AndEvery(5).Seconds();
        }
    }
}
