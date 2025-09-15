using RabbitMQ.Client;
using System;
using System.Text;

var factory = new ConnectionFactory() { HostName = "localhost" };

await using var connection = await factory.CreateConnectionAsync();
await using var channel = await connection.CreateChannelAsync();

await channel.ExchangeDeclareAsync(exchange: "logs", type: ExchangeType.Fanout);

var message = GetMessage(args);
var body = Encoding.UTF8.GetBytes(message);
await channel.BasicPublishAsync(
    exchange: "logs",
    routingKey: "",
    body: body);

Console.WriteLine($" [x] Sent {message}");

string GetMessage(string[] args)
{
    return ((args.Length > 0)
        ? string.Join(" ", args)
        : "info: Hello World!");
}
