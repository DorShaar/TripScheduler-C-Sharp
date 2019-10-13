using Apache.NMS;
using Apache.NMS.ActiveMQ;
using QueueAdapter.Interfaces;
using System;
using System.Text;

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

        public void RecieveMessage(string destinationName)
        {
            try
            {
                IDestination dest = mSession.GetDestination(destinationName);
                using (IMessageConsumer consumer = mSession.CreateConsumer(dest))
                {
                    Console.WriteLine($"Start listening to {destinationName}");

                    while (true)
                    {
                        IMessage message = consumer.Receive();
                        if (message != null)
                        {
                            if (message is IBytesMessage byteMessage)
                            {
                                string textMessage = Encoding.UTF8.GetString(byteMessage.Content);
                                if (!string.IsNullOrEmpty(textMessage))
                                    Console.WriteLine($"Recieved message: {textMessage}");
                            }

                            Console.WriteLine($"Could not parse message, type of message is: {message.NMSType}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine("Press <ENTER> to exit.");
                Console.Read();
            }
        }

        public void SendMessage(string message, string destinationName)
        {
            try
            {
                IDestination destination = mSession.GetDestination(destinationName);
                using (IMessageProducer producer = mSession.CreateProducer(destination))
                {
                    var textMessage = producer.CreateTextMessage(message);
                    producer.Send(textMessage);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}