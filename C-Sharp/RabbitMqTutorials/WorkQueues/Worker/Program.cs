using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Text;
using System.Threading;

namespace Worker
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var factory = new ConnectionFactory() { HostName = "localhost" };
            using (IConnection connection = factory.CreateConnection())
            {
                using (IModel channel = connection.CreateModel())
                {
                    channel.QueueDeclare(queue: "task_queue",
                        durable: true,
                        exclusive: false,
                        autoDelete: false,
                        arguments: null);
                    var consumer = new EventingBasicConsumer(channel);
                    consumer.Received += (model, ea) =>
                    {
                        var body = ea.Body;
                        var message = Encoding.UTF8.GetString(body);
                        Console.WriteLine(" [x] Received {0}", message);

                        var parts = message.Split(" ");

                        if (parts.Length == 2)
                        {
                            Console.WriteLine(parts[0]);

                            if (int.TryParse(parts[1], out var work))
                            {
                                for (var i = 0; i < work; i++)
                                {
                                    Console.Write(".");
                                    Thread.Sleep(TimeSpan.FromSeconds(1));
                                }

                                Console.WriteLine();
                            }
                            else
                            {
                                Console.WriteLine($"Unable to parse '{parts[1]}' to an int.");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Unable to split '{message}'.");
                        }

                        Console.WriteLine(" [x] Done");

                        channel.BasicAck(deliveryTag: ea.DeliveryTag, multiple: false);
                    };
                    channel.BasicConsume(queue: "task_queue", autoAck: false, consumer: consumer);

                    Console.WriteLine(" Press [enter] to exit.");
                    Console.ReadLine();
                }
            }
        }
    }
}