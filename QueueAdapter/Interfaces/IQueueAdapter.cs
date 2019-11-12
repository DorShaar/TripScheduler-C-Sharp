using System;
using System.Threading;
using System.Threading.Tasks;
using TripScheduler.Interfaces;

namespace QueueAdapter.Interfaces
{
    public interface IQueueAdapter
    {
        Task RecieveMessages(
            Func<ISchedule, Task<IScheduleRank>> handler,
            string recieveMessagesChannelName,
            string sendMessageChannelName,
            CancellationToken cancellationToken);
    }
}