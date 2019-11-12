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
            SchedulerRanker schedulerRanker = new SchedulerRanker();
            RankingStrategyBuilder rankingStrategyBuilder = new RankingStrategyBuilder()
            {
                DayWithEventsBadPoints = 2,
                EmptyOneHourSlotBadPoints = 1
            };

            Func<ISchedule, Task<double>> rankingStrategy = rankingStrategyBuilder.BuildStrategy();

            Task recieveMessagesTask = mQueueAdapter.RecieveMessage(
                schedulerRanker.RankSchedule(, rankingStrategy), new CancellationToken());

            Task sendMessageTask = mQueueAdapter.SendMessage(,);

            Task.WaitAll(recieveMessagesTask, sendMessageTask);
        }
    }
}