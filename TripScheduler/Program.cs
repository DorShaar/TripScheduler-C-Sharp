using QueueAdapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TripScheduler.Interfaces;

namespace TripScheduler
{
    class Program
    {
        static async Task Main()
        {
            IQueueAdapter queueAdapter = new QueueAdapter.ActiveMQ.QueueAdapter();
            queueAdapter.Connect();
            queueAdapter.RecieveMessage("some_queue");

            return;

            SchedulerRanker schedulerRanker = new SchedulerRanker();
            RankingStrategyBuilder rankingStrategyBuilder = new RankingStrategyBuilder()
            {
                DayWithEventsBadPoints = 2
            };


            Func<ISchedule, Task<double>> rankingStrategy = rankingStrategyBuilder.BuildStrategy();
            // Dictionary<id(int), rank(double)>.
            Dictionary<int, double> scheduleRanksDict = new Dictionary<int, double>();

            List<ISchedule> schedules = await GetSchedules();
            foreach (ISchedule schedule in schedules)
            {
                scheduleRanksDict[schedule.ID] = schedulerRanker.RankSchedule(schedule, rankingStrategy);
            }
        }

        // TODO
        private static Task<List<ISchedule>> GetSchedules()
        {
            return Task.FromResult(new List<ISchedule>());
        }
    }
}