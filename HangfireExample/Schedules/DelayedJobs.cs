using HangfireExample.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HangfireExample.Schedules
{
    public static class DelayedJobs
    {
        public static void DelayedExample()
        {
            Hangfire.BackgroundJob.Schedule<DelayedExampScheduleJobManager>(
                job => Console.WriteLine("DelayedManager is calling!"),
                TimeSpan.FromSeconds(10));
        }
    }
}
