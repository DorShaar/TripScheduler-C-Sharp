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
            string queueName = "schedules";
            bool isFinishedSigneled = false;

            IQueueAdapter queueAdapter = new QueueAdapter.ActiveMQ.QueueAdapter();
            queueAdapter.Connect();
            
            while(!isFinishedSigneled)
            {
                byte[] message = await queueAdapter.RecieveMessage(queueName);
                ScheduleDto.Schedule schedule = ScheduleDto.Schedule.Parser.ParseFrom(message);

                SchedulerRanker schedulerRanker = new SchedulerRanker();
                RankingStrategyBuilder rankingStrategyBuilder = new RankingStrategyBuilder()
                {
                    DayWithEventsBadPoints = 2,
                    EmptyOneHourSlotBadPoints = 1
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
        }
    }
}