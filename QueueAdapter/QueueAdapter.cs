using Apache.NMS;
using Apache.NMS.ActiveMQ;
using QueueAdapter.Interfaces;
using System;
using System.Threading.Tasks;

namespace QueueAdapter.ActiveMQ
{
    public class QueueAdapter : IQueueAdapter
    {
        private IConnectionFactory mConnectionFactory;
        private IConnection mConnection;
        private ISession mSession;

        public string URI { get; } = "activemq:tcp://localhost:61616";

        public void Connect()
        {
            mConnectionFactory = new ConnectionFactory(URI);
            if (mConnection == null)
            {
                mConnection = mConnectionFactory.CreateConnection();
                mConnection.Start();
                mSession = mConnection.CreateSession();

                Console.WriteLine($"Connected to {URI}");
                return;
            }

            Console.WriteLine($"Connected is already available");
        }

        public Task<byte[]> RecieveMessage(string destinationName)
        {
            byte[] byteMessageContent = new byte[] { };

            try
            {
                IDestination dest = mSession.GetDestination(destinationName);
                using (IMessageConsumer consumer = mSession.CreateConsumer(dest))
                {
                    Console.WriteLine($"Start listening to {destinationName}");

                    IMessage message = consumer.Receive();
                    if (message != null)
                    {
                        if (message is IBytesMessage byteMessage)
                        {
                            byteMessageContent = byteMessage.Content;
                            return Task.FromResult(byteMessageContent);
                        }

                        Console.WriteLine($"Could not parse message, type of message is: {message.NMSType}");
                        return Task.FromResult(byteMessageContent);
                    }

                    Console.WriteLine($"Null Message");
                    return Task.FromResult(byteMessageContent);
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

        public void SendMessage(byte[] message, string destinationName)
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

        public void Dispose()
        {
            mSession.Dispose();
            mConnection.Dispose();
        }
    }
}