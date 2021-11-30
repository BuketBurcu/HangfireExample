using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HangfireExample.Schedules
{
    public static class ContinuationsJob
    {
        public static void ContinuationExamp()
        {
            var parentJobId = Hangfire.BackgroundJob.Schedule(() => Console.WriteLine("1. Job"), TimeSpan.FromSeconds(10));
            Hangfire.BackgroundJob.ContinueWith(parentJobId, () => Console.WriteLine("2. Job"));

        }
    }
}
