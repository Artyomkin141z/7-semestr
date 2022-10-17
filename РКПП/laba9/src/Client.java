import java.net.*;
import java.io.*;

public class Client {
    public static void run(){
        Socket socket = null;
        try {// получение строки клиентом
            socket = new Socket("localhost", 8030);
            BufferedReader dis = new BufferedReader(new
                    InputStreamReader( socket.getInputStream()));
            String msg = dis.readLine();
            //msg.replace('~', '\n');
            System.out.print(msg.replace('~', '\n'));
        } catch (IOException e) {
            System.out.println("ошибка: " + e);
        }
    }

    public static void main(String[] args) {
        //Server server = new Server();
        run();
    }
}
