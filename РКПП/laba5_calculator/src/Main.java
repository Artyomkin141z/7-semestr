

public class Main {
    public static void main(String[] args){
        Object o1 = new Integer(3);
        Calculator calculator = new Calculator();

        o1 = calculator;
        calculator = null;

        System.gc();
        //Runtime.getRuntime().gc();
    }
}