package calculator;

public class Calculator {
    public void printCondition(String str){
        String[] arguments = str.split("\\s");
        try {
            if(str.equals("exit") || str.equals("0")){}
            else if(arguments.length < 3 || arguments.length > 3) {
                this.err("Неправельно набран пример\nФормат: x (условие) y");
            }
            if(arguments.length == 3){
                Double x = Double.parseDouble(arguments[0]);
                Double y = Double.parseDouble(arguments[2]);

                String action = arguments[1];
                System.out.print(x.toString()
                        + " "
                        + action.toString()
                        + " "
                        + y.toString()
                        + " = "
                        + (calculation(action, x, y))
                );
            }
        }
        catch (Exception e){
            //System.out.println(e);
        }
    }
    private void err(String msg){
        System.out.println(msg);
    }
    private double calculation(String action, Double x, Double y){
        if(action.equals("+")){
            return x + y;
        }
        else if(action.equals("-")){
            return x - y;
        }
        else if(action.equals("*")){
            return x * y;
        }
        else if(action.equals("/")){
            return x / y;
        }
        else if(action.equals("**")){
            return Math.pow(x, y);
        }
        else{
            //return new Exception("Я не смог посчитать твой пример");
            return 1231231;
        }
        //return 0;
    }
}
