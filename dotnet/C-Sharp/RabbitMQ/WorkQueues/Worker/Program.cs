using RabbitMQ.Client;
using System.Text;
using RabbitMQ.Client.Events;

var factory = new ConnectionFactory { HostName = "localhost" };
await using var connection = await factory.CreateConnectionAsync();
await using var channel = await connection.CreateChannelAsync();
await channel.QueueDeclareAsync(
    queue: "task_queue",
    durable: true,
    exclusive: false,
    autoDelete: false,
    arguments: null);
var consumer = new AsyncEventingBasicConsumer(channel);

consumer.ReceivedAsync += async (model, ea) =>
{
    var body = ea.Body;
    var message = Encoding.UTF8.GetString(body.ToArray());
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

    await channel.BasicAckAsync(deliveryTag: ea.DeliveryTag, multiple: false);
};

await channel.BasicConsumeAsync(queue: "task_queue", autoAck: false, consumer: consumer);

Console.WriteLine(" Press [enter] to exit.");
Console.ReadLine();