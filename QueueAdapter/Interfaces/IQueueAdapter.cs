using System;
using System.Threading.Tasks;

namespace QueueAdapter.Interfaces
{
    public interface IQueueAdapter : IDisposable
    {
        void Connect();
        Task<byte[]> RecieveMessage(string destinationName);
        void SendMessage(byte[] message, string destinationName);
    }
}