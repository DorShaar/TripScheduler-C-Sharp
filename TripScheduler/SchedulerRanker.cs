using System;
using System.Threading.Tasks;
using TripScheduler.Interfaces;

namespace TripScheduler
{
    internal class SchedulerRanker : IScheduleRanker
    {
        public async Task<ScheduleRank> RankSchedule(ISchedule schedule, Func<ISchedule, Task<double>> rankAlgorithm)
        {
            //SchedulerRanker schedulerRanker = new SchedulerRanker();
            //RankingStrategyBuilder rankingStrategyBuilder = new RankingStrategyBuilder()
            //{
            //    DayWithEventsBadPoints = 2,
            //    EmptyOneHourSlotBadPoints = 1
            //};

            //Func<ISchedule, Task<double>> rankingStrategy = rankingStrategyBuilder.BuildStrategy();

            double rank = await rankAlgorithm(schedule);
            return new ScheduleRank(schedule.ID, rank);
        }
    }
}