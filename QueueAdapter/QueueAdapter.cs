using Apache.NMS;
using Apache.NMS.ActiveMQ;
using QueueAdapter.Interfaces;
using System;
using System.Threading;
using System.Threading.Tasks;

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

        public Task RecieveMessage(string destinationName, CancellationToken cancellationToken = default)
        {
            byte[] byteMessageContent = new byte[] { };

            try
            {
                using (ISession session = mConnection.CreateSession())
                using (IDestination dest = session.GetDestination(destinationName))
                using (IMessageConsumer consumer = session.CreateConsumer(dest))
                {
                    Console.WriteLine($"Start listening to {destinationName}");

                    while(!cancellationToken.IsCancellationRequested)
                    {
                        IMessage message = consumer.Receive();
                        if (message != null)
                        {
                            if (message is IBytesMessage byteMessage)
                            {
                                // adapter should not know about dtos.
                                ScheduleDto.Schedule schedule = ScheduleDto.Schedule.Parser.ParseFrom(byteMessage.Content);
                                // call scheduleRanker func.
                            }

                            Console.WriteLine($"Could not parse message, type of message is: {message.NMSType}");
                        }

                        Console.WriteLine($"Null message recieved");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine("Press <ENTER> to exit.");
                Console.Read();
                return Task.FromResult(byteMessageContent);
            }
        }

        public Task SendMessage(byte[] message, string destinationName, CancellationToken cancellationToken = default)
        {
            try
            {
                IDestination destination = mSession.GetDestination(destinationName);
                using (IMessageProducer producer = mSession.CreateProducer(destination))
                {
                    producer.Send(producer.CreateBytesMessage(message));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}