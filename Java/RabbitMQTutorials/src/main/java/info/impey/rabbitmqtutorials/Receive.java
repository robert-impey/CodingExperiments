/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package info.impey.rabbitmqtutorials;

import com.rabbitmq.client.ConnectionFactory;
import com.rabbitmq.client.Connection;
import com.rabbitmq.client.Channel;
import com.rabbitmq.client.QueueingConsumer;
import java.io.IOException;

/**
 *
 * @author Robert
 */
public class Receive {

    private static final String QUEUE_NAME = "hello";

    public static void main(String[] args) throws
            IOException, InterruptedException {
        ConnectionFactory connectionFactory = new ConnectionFactory();
        connectionFactory.setHost("localhost");
        Connection connection = connectionFactory.newConnection();
        Channel channel = connection.createChannel();

        channel.queueDeclare(QUEUE_NAME, false, false, false, null);
        System.out.println("Waiting for messages");
        
        QueueingConsumer queueingConsumer = new QueueingConsumer(channel);
        channel.basicConsume(QUEUE_NAME, true, queueingConsumer);
        
        while(true) {
            QueueingConsumer.Delivery delivery = queueingConsumer.nextDelivery();
            String message = new String(delivery.getBody());
            System.out.printf("Received: %s\n", message);
        }
    }
}
