using System;
using System.Threading;
using System.Threading.Tasks;

namespace QueueAdapter.Interfaces
{
    public interface IQueueAdapter
    {
        Task RecieveMessage(string destinationName, CancellationToken cancellationToken);
        Task SendMessage(byte[] message, string destinationName, CancellationToken cancellationToken);
    }
}