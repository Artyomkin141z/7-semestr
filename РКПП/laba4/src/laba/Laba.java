package laba;

import laba.paterns.Adapter;
import laba.paterns.TemplateMethod;
import laba.paterns.Singleton;

public class Laba {
    public static void main(String[] args){
        System.out.println("Adapter");
        Adapter adapter = new Adapter();
        adapter.test();

        System.out.println("");
        System.out.println("Singleton");
        Singleton singelton = Singleton.getInstance();
        singelton.setUp();

        System.out.println("");
        System.out.println("Template method");
        TemplateMethod tm = new TemplateMethod();
        tm.test();
    }
}
