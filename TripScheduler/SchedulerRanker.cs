using ScheduleRank;
using System;
using System.Threading.Tasks;
using TripScheduler.Interfaces;

namespace TripScheduler
{
    internal class SchedulerRanker
    {
        public async Task<IScheduleRank> RankSchedule(ISchedule schedule, Func<ISchedule, Task<double>> rankAlgorithm)
        {
            double rank = await rankAlgorithm(schedule);
            ScheduleRank.ScheduleRank scheduleRank = new ScheduleRank.ScheduleRank()
            {
                ID = schedule.ID,
                Rank = rank
            };
            return scheduleRank;
        }
    }
}