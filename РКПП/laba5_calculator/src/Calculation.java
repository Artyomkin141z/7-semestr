import java.util.ArrayList;

public class Calculation {
    String strNumber = "";
    Boolean isDot = false;
    String lastOperator = "";
    String X = "", Y = "";
    String answer = "", strExample = "";


    public String getAnswer(){
        saveNumber();
        this.answer = caclulateNumber();
        return this.answer;
    }
    public String getStrExample(){
        this.strExample = this.X + " " + this.lastOperator + " " + this.Y + " =";
        return this.strNumber;
    }
    public String getStrNumber(){return this.strNumber;}
    public void setLastOperator(String value){
        saveNumber();
        this.lastOperator = value;
    }
    public void saveNumber(){
        if(strNumber.toCharArray()[strNumber.length()-1] == '.'){
            strNumber += "0";
        }
        else if(strNumber.indexOf(".") == -1){
            strNumber += ".0";
        }
        if(X == ""){
            this.X = strNumber;
        }
        else {
            this.X = caclulateNumber();
            this.Y = strNumber;
        }
        this.strNumber = "";
    }
    public void printStrNumber(String symbol){
        strNumber += symbol;
    }

    public String caclulateNumber(){
        double x = Double.parseDouble(this.X);
        double y = Double.parseDouble(this.Y);
        double a = 0.0;
        if(lastOperator == "*"){
            a = x * y;
        }
        return Double.toString(a);
    }
}
