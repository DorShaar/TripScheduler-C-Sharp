using Dto;
using System;
using System.Threading.Tasks;
using TripScheduler.Interfaces;

namespace TripScheduler
{
    internal class SchedulerRanker
    {
        public async Task<IScheduleRank> RankSchedule(ISchedule schedule, Func<ISchedule, Task<double>> rankAlgorithm)
        {
            //SchedulerRanker schedulerRanker = new SchedulerRanker();
            //RankingStrategyBuilder rankingStrategyBuilder = new RankingStrategyBuilder()
            //{
            //    DayWithEventsBadPoints = 2,
            //    EmptyOneHourSlotBadPoints = 1
            //};

            //Func<ISchedule, Task<double>> rankingStrategy = rankingStrategyBuilder.BuildStrategy();

            double rank = await rankAlgorithm(schedule);
            ScheduleRank scheduleRank = new ScheduleRank()
            {
                ID = schedule.ID,
                Rank = rank
            };
            return scheduleRank;
        }
    }
}