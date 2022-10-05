package Laba;

import java.util.*;

public class Laba {
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

    public static void main(String[] arguments){
        System.out.println("Лабораторная работа №7\n");

        Stack st = new Stack();
        System.out.println("Стек: " + st);
        pushStack(st, 42);
        pushStack(st, 66);
        pushStack(st, 99);
        popStack(st);
        popStack(st);
        popStack(st);
        try {
            popStack(st);
        } catch (EmptyStackException e) {
            System.out.println("Пустой стек");
        }
    }
}
