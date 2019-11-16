using Composition;
using Microsoft.Extensions.Options;
using QueueAdapter.Interfaces;
using System;
using System.Threading;
using System.Threading.Tasks;
using TripScheduler;
using TripScheduler.Configuration;
using TripScheduler.Interfaces;

namespace Runner
{
    public class Program
    {
        private static readonly IQueueAdapter mQueueAdapter = new QueueAdapter.ActiveMQ.QueueAdapter();
        private static readonly TripSchedulerServiceProvider mServiceProvider = new TripSchedulerServiceProvider();

        public static void Main(string[] args)
        {
            IOptions<ChannelsOptions> channelsOptions = mServiceProvider.GetChannelOptions();
            IOptions<RankingStrategyOptions> rankingStrategyOptions = mServiceProvider.GetRankingStrategyOptions();

            RankingStrategyBuilder rankingStrategyBuilder = new RankingStrategyBuilder()
            {
                DayWithEventsBadPoints = rankingStrategyOptions.Value.DayWithEventsBadPoints,
                EmptyOneHourSlotBadPoints = rankingStrategyOptions.Value.EmptyOneHourSlotBadPoints
            };

            SchedulerRanker schedulerRanker = new SchedulerRanker(rankingStrategyBuilder.BuildStrategy());

            Func<ISchedule, Task<double>> rankingStrategy = rankingStrategyBuilder.BuildStrategy();

            Task recieveMessagesTask = mQueueAdapter.RecieveMessages(
                schedulerRanker.RankSchedule,
                channelsOptions.Value.RecieveChannelName,
                channelsOptions.Value.SendChannelName,
                new CancellationToken());

            recieveMessagesTask.Wait();
        }
    }
}