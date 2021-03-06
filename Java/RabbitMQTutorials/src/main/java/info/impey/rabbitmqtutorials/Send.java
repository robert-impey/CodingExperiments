/*
 * See http://www.rabbitmq.com/tutorials/tutorial-one-java.html
 */
package info.impey.rabbitmqtutorials;

import com.rabbitmq.client.ConnectionFactory;
import com.rabbitmq.client.Connection;
import com.rabbitmq.client.Channel;

/**
 *
 * @author Robert
 */
public class Send {

    private static final String QUEUE_NAME = "hello";

    public static void main(String[] args) throws Exception {
        ConnectionFactory connectionFactory = new ConnectionFactory();
        connectionFactory.setHost("localhost");
        try (Connection connection = connectionFactory.newConnection();
            Channel channel = connection.createChannel()) {

            channel.queueDeclare(QUEUE_NAME, false, false, false, null);
            String message = "Hello, World!";
            channel.basicPublish("", QUEUE_NAME, null, message.getBytes());

            System.out.printf("Sent: %s\n", message);
        }
    }
}
