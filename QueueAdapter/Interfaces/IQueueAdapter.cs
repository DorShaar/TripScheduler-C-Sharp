namespace QueueAdapter.Interfaces
{
    public interface IQueueAdapter
    {
        void Connect();
        void RecieveMessage(string destinationName);
        void SendMessage(string message, string destinationName);
    }
}