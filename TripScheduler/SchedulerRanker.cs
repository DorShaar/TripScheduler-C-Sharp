using System;
using System.Threading.Tasks;
using TripScheduler.Interfaces;

namespace TripScheduler
{
    internal class SchedulerRanker
    {
        Func<ISchedule, Task<double>> RankAlgorithm { get; set; }

        public SchedulerRanker(Func<ISchedule, Task<double>> rankAlgorithm)
        {
            RankAlgorithm = rankAlgorithm;
        }

        public async Task<IScheduleRank> RankSchedule(ISchedule schedule)
        {
            double rank = await RankAlgorithm(schedule);
            ScheduleRank.ScheduleRank scheduleRank = new ScheduleRank.ScheduleRank()
            {
                ID = schedule.ID,
                Rank = rank
            };
            return scheduleRank;
        }
    }
}