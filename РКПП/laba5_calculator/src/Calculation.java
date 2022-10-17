import java.util.ArrayList;

public class Calculation {
    String strNumber = "";
    Boolean isDot = false;
    String lastOperator = "";
    String X = "", Y = "";
    String answer = "", strExample = "";
    String memory = "";


    public void addMemory(){
        this.memory = this.answer;
    }
    public void removeMemory(){
        this.memory = "";
    }
    public void setMemory(){
        saveNumber();
        printStrNumber(memory);
        isDot = true;
    }
    public void changeMemory(String value){
        String a = "";
        if(answer != ""){
            a = answer;
        }
        else if(Y == ""){
            a = X;
        }
        else {
            a = Y;
        }
        double x = Double.parseDouble(a);
        double m = Double.parseDouble(memory);
        if(value == "M+"){
            m += x;
        }
        else if(value == "M-"){
            m -= x;
        }
        memory = Double.toString(m);
    }
    public String getAnswer(){
        if(answer == ""){
            saveNumber();
            this.answer = caclulateNumber();
            System.out.println("getAnswer:" + this.answer);
        }
        else{
            this.X = this.answer;
            this.answer = caclulateNumber();
            System.out.println("getAnswer =:" + this.answer);
        }
        return this.answer;
    }
    public String getStrExample(){
        if(this.answer == "" && this.Y == ""){
            this.strExample = this.X + " " + this.lastOperator;
        }
        else if(this.answer == "" && this.Y != ""){
            this.strExample = caclulateNumber() + " " + this.lastOperator;
        }
        else {
            this.strExample = this.X + " " + this.lastOperator + " " + this.Y + " =";
        }
        return this.strExample;
    }
    public String getStrNumber(){return this.strNumber;}
    public void setLastOperator(String value){
        if(answer != ""){
            //this.X = answer;
            saveNumber();
            answer = "";
            this.lastOperator = value;
        }
        else{
            saveNumber();
            isDot = false;
            this.lastOperator = value;
        }
    }
    public void changeNumber(String value){
        if(strNumber == ""){
            strNumber = "0";
        }
        if(answer != ""){
            strNumber = answer;
        }
        double x = Double.parseDouble(strNumber);
        double a = 0.0;
        if(value == "1/x"){
            if(x == 0.0){
                strNumber = "На 0 делить нельзя";
            }
            else{
                a = 1/x;
                strNumber = Double.toString(a);
            }
        }
        else if(value == "x^2"){
            a = x * x;
            strNumber = Double.toString(a);
        }
        else if(value == "sqr"){
            if(x < 0){
                clearCalculator();
                strNumber = "Отрицательное число под корнем";
            }
            else{
                a = Math.sqrt(x);
                strNumber = Double.toString(a);
            }
        }
        else if(value == "+/-"){
            a = x * -1.0;
            strNumber = Double.toString(a);
        }
        else if(value == "%"){
            a = x / 100.0;
            strNumber = Double.toString(a);
        }
        //answer = strNumber;
    }
    public void saveNumber(){
        if(X == ""){
            this.X = strNumber;
        }
        else if(Y == "" && X != "") {
            this.Y = strNumber;
        }
        else{
            this.X = caclulateNumber();
            this.Y = strNumber;
        }
        System.out.println("X: " + this.X);
        System.out.println("Y: " + this.Y);
        this.strNumber = "";
    }
    public void checkNum(){
        if(strNumber == "Отрицательное число под корнем" || strNumber == "На 0 делить нельзя"){
            clearCalculator();
            System.out.println("checkNum");
        }
    }
    public void printStrNumber(String symbol){
        if(answer != ""){
            clearCalculator();
        }
        if(symbol == "." && isDot != true){
            strNumber += symbol;
        }
        else if(symbol != "."){
            strNumber += symbol;
        }
    }
    public void clearStrNumber(){
        if(answer != ""){
            clearCalculator();
        }
        else if(strNumber != ""){
            strNumber = strNumber.substring(0, strNumber.length() - 1);
        }
    }
    public String caclulateNumber(){
        if(this.Y == ""){
            return this.X;
        }
        System.out.println("caclulateNumber X: " + this.X);
        System.out.println("caclulateNumber Y: " + this.Y);
        double x = Double.parseDouble(this.X);
        double y = Double.parseDouble(this.Y);
        double a = 0.0;
        if(lastOperator == "*"){
            a = x * y;
        }
        else if(lastOperator == "/"){
            if(y == 0.0) {
                clearCalculator();
                return "На 0 делить нельзя";
            }
            a = x / y;
        }
        else if(lastOperator == "+"){
            a = x + y;
        }
        else if(lastOperator == "-"){
            a = x - y;
        }
        return Double.toString(a);
    }
    public void clearCalculator(){
        this.X = "";
        Y = "";
        answer = "";
        strNumber = "";
        isDot = false;
        lastOperator = "";
        strExample = "";
    }
}
