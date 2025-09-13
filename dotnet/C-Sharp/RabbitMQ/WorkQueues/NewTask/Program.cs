using RabbitMQ.Client;
using System.Text;

namespace NewTask
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            var factory = new ConnectionFactory { HostName = "localhost" };
            await using var connection = await factory.CreateConnectionAsync();
            await using var channel = await connection.CreateChannelAsync();
            await channel.QueueDeclareAsync(
                queue: "task_queue",
                durable: true,
                exclusive: false,
                autoDelete: false,
                arguments: null);

            var message = GetMessage(args);
            var body = Encoding.UTF8.GetBytes(message);

            var properties = new BasicProperties
            {
                Persistent = true
            };

            //await channel.BasicQosAsync(0, 1, false);

            await channel.BasicPublishAsync(
                exchange: string.Empty,
                routingKey: "task_queue",
                mandatory: true,
                basicProperties: properties,
                body: body);
        }

        private static string GetMessage(string[] args)
        {
            return args.Length > 0 ? string.Join(" ", args) : "Red 3";
        }
    }
}