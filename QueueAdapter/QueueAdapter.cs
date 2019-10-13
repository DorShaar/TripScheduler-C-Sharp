using Apache.NMS;
using Apache.NMS.ActiveMQ;
using System;

namespace ActiveMQ.QueueAdapter
{
    public class QueueAdapter
    {
        private IConnectionFactory mConnectionFactory;
        private IConnection mConnection;
        private ISession mSession;

        public string URI { get; } = "activemq:tcp://localhost:8161";

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

                    IMessage message;
                    while (true)
                    {
                        message = consumer.Receive();
                        if (message != null)
                        {
                            ITextMessage textMessage = message as ITextMessage;
                            if (!string.IsNullOrEmpty(textMessage.Text))
                                Console.WriteLine($"Recieved message: {textMessage.Text}");
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