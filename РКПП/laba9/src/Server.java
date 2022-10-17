import java.io.*;
import java.net.*;

public class Server {
    public static void run(){
        Socket s = null;
        try {// посылка строки клиенту
            File file = new File("F:\\Учеба\\7 сем\\РКПП\\laba9\\src\\client.txt");
            //создаем объект FileReader для объекта File
            FileReader fr = new FileReader(file);
            FileReader fr2 = new FileReader(file);
            //создаем BufferedReader с существующего FileReader для построчного считывания
            BufferedReader reader = new BufferedReader(fr);
            BufferedReader reader2 = new BufferedReader(fr2);
            // считаем сначала первую строку
            int lines = 0;
            while (reader2.readLine() != null) lines++;

            String line = "";

            double a = Math.random() * (lines + 1);
            int b = (int) (a);
            for(int i = 0; i < a - 1; i++)  line = reader.readLine();
            line = reader.readLine();

            ServerSocket server = new ServerSocket(8030);
            s = server.accept();
            PrintStream ps = new PrintStream(s.getOutputStream());
            ps.println(line);
            ps.flush();
            s.close(); // разрыв соединения
        } catch (IOException e) {
            System.out.println("ошибка: " + e);
        }
    }

    public static void main(String[] args) {
        run();
    }
}
