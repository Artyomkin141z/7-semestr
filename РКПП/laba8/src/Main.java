import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;
import java.util.Scanner;
import java.util.Stack;

public class Main {
    static void outFile(Stack st, FileInputStream fileOut) throws IOException {
        int num;
        while ((num = fileOut.read()) != -1) {
            pushStack(st, (Integer)num);
        }
        System.out.println("-> Файл открыт <-");
    }
    static void inFile(Stack st, FileOutputStream fileIn) throws IOException {
        while (!st.empty()) {
            fileIn.write(st.pop().toString().getBytes());
        }
        System.out.println("<- Стек успешно записан в файл ->");
    }
    static void pushStack(Stack st, int a) {
        st.push(new Integer(a));
        System.out.println("Добавлено значение(" + a + ")");
        System.out.println("Стек: " + st);
    }

    static void popStack(Stack st) {
        System.out.print("Удален верхний элемент -> ");
        Integer a = (Integer) st.pop();
        System.out.println(a);
        System.out.println("Стек: " + st);
    }

    public static void main(String[] arguments) throws IOException {
        System.out.println("Лабораторная работа №7\n");
        System.out.println("1 -> Добавить значение в стек");
        System.out.println("2 -> Удалить значение из стека");
        System.out.println("3 -> Записать стек в файл");
        System.out.println("4 -> Импортировать стек из файл");
        System.out.println("Выход: exit");

        Stack st = new Stack();

        FileInputStream fileIn = new FileInputStream("F:\\Учеба\\7 сем\\РКПП\\laba8\\in.txt");
        FileOutputStream fileOut = new FileOutputStream("F:\\Учеба\\7 сем\\РКПП\\laba8\\out.txt");

        Scanner in = new Scanner(System.in);
        String example = "";
        while(example.equals("exit") == false){
            System.out.print("\nВведите операцию: ");
            example = in.nextLine();

            switch (example){
                case "1":
                    System.out.print("\nВведите число: ");
                    Integer n = Integer.parseInt(in.nextLine());
                    pushStack(st, n);
                    break;
                case "2":
                    popStack(st);
                    break;
                case "3":
                    inFile(st, fileOut);
                    break;
                case "4":
                    outFile(st, fileIn);
                    break;
                case "exit":
                    break;
            }
        }
        in.close();
        fileIn.close();
        fileOut.close();
    }
}