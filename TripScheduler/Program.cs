using QueueAdapter.Interfaces;
using System;
using System.Threading;
using System.Threading.Tasks;
using TripScheduler.Interfaces;

namespace TripScheduler
{
    public class Program
    {
        private static readonly IQueueAdapter mQueueAdapter = new QueueAdapter.ActiveMQ.QueueAdapter();

        public static void Main()
        {
            // TODO move to config file:
            RankingStrategyBuilder rankingStrategyBuilder = new RankingStrategyBuilder()
            {
                DayWithEventsBadPoints = 2,
                EmptyOneHourSlotBadPoints = 1
            };

            SchedulerRanker schedulerRanker = new SchedulerRanker(rankingStrategyBuilder.BuildStrategy());

            string inChannelName = "in";
            string outChannelName = "out";

            // END TODO

            Func<ISchedule, Task<double>> rankingStrategy = rankingStrategyBuilder.BuildStrategy();

            Task recieveMessagesTask = mQueueAdapter.RecieveMessages(
                schedulerRanker.RankSchedule,
                inChannelName,
                outChannelName,
                new CancellationToken());

            recieveMessagesTask.Wait();
        }
    }
}