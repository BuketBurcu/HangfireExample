using HangfireExample.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HangfireExample.Schedules
{
    public static class RecurringJobs
    {
        public static void RecurringExample()
        {
            Hangfire.RecurringJob.AddOrUpdate<RecurringExampScheduleJobManager>(
                job => Console.WriteLine("RecurringJobs is calling"),
                cronExpression: "35 16 * * *", TimeZoneInfo.Local);
        }
    }
}
