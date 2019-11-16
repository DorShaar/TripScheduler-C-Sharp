using Apache.NMS;
using Apache.NMS.ActiveMQ;
using Google.Protobuf;
using QueueAdapter.Interfaces;
using System;
using System.Threading;
using System.Threading.Tasks;
using TripScheduler.Interfaces;

namespace QueueAdapter.ActiveMQ
{
    public class QueueAdapter : IQueueAdapter
    {
        private IConnection mConnection;
        public string URI { get; } = "activemq:tcp://localhost:61616";

        public QueueAdapter()
        {
            SetupConnection();
        }

        private void SetupConnection()
        {
            mConnection = new ConnectionFactory(URI).CreateConnection();
        }

        public async Task RecieveMessages(
            Func<ISchedule, Task<IScheduleRank>> handler,
            string recieveMessagesChannelName,
            string sendMessageChannelName,
            CancellationToken cancellationToken = default)
        {
            using (ISession session = mConnection.CreateSession())
            using (IDestination dest = session.GetTopic(recieveMessagesChannelName))
            using (IMessageConsumer consumer = session.CreateConsumer(dest))
            {
                Console.WriteLine($"Start listening to {recieveMessagesChannelName}");

                while (!cancellationToken.IsCancellationRequested)
                {
                    Apache.NMS.IMessage message = consumer.Receive();
                    if (message != null)
                    {
                        if (message is IBytesMessage byteMessage)
                        {
                            ScheduleDto.Schedule schedule = ScheduleDto.Schedule.Parser.ParseFrom(byteMessage.Content);
                            IScheduleRank scheduleRank = await handler(schedule);
                            SendMessage((scheduleRank as ScheduleRank.ScheduleRank).ToByteArray(), sendMessageChannelName);
                        }

                        Console.WriteLine($"Could not parse message, type of message is: {message.NMSType}");
                    }

                    Console.WriteLine($"Null message recieved");
                }
            }
        }

        private void SendMessage(byte[] messageData, string destinationName)
        {
            using (ISession session = mConnection.CreateSession())
            using (IDestination destination = session.GetTopic(destinationName))
            using (IMessageProducer producer = session.CreateProducer(destination))
            {
                producer.Send(producer.CreateBytesMessage(messageData));
            }
        }
    }
}