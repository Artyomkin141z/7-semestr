package calculator;

import java.util.Scanner;
import calculator.Calculator;

public class Laba {
    public static void main(String[] arguments){
        System.out.println("\nФормат: \"число\" + \"пробел\" + \"выражение\" + \"пробел\" + \"число\"");
        System.out.println("+ | - | * | / | **(возведение в степень)");
        System.out.println("Выход: exit");

        Calculator calculator = new Calculator();
        String example = "";
        Scanner in = new Scanner(System.in);
        while(example.equals("exit") == false){
            System.out.print("\nВведите уравнение: ");
            example = in.nextLine();

            calculator.printCondition(example);
        }
        in.close();
    }
}
