import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class Calculator extends JFrame implements ActionListener {
    private JTextField inputJT;
    private JTextField numberJT;
    private JButton num1;
    private JButton num2;
    private JButton num3;
    private JButton num4;
    private JButton num5;
    private JButton num6;
    private JButton num7;
    private JButton num8;
    private JButton num9;
    private JButton num0;

    private JButton operProc;//Процент
    private JButton operCE;
    private JButton operC;
    private JButton operErase;//Стереть
    private JButton operFraction;//1/х
    private JButton operSquare;//Квадрат
    private JButton operRoot;//Корень
    private JButton operDevide;//Разделить
    private JButton operMultiply;//Умножить
    private JButton operMinus;//Минус
    private JButton operPlus;//Плюс
    private JButton operDot;//Точка
    private JButton operEarly;//Равно
    private JButton operSign;//Знак числа


    private Calculation c;
    Calculator(){
        c = new Calculation();

        this.setTitle("Калькулятор (Лаба 5)");
        //this.setSize(1000, 1000);
        this.setResizable(false);
        Container c = this.getContentPane();
        c.setLayout(new BorderLayout());

        JPanel calcPanel = new JPanel(new GridLayout(2, 1));
        this.getContentPane().add(calcPanel, "North");

        // Пример
        this.inputJT = new JTextField("");
        this.inputJT.setHorizontalAlignment(4);
        this.inputJT.setEditable(false);
        this.inputJT.setBackground(Color.white);

        // Пример
        this.numberJT = new JTextField("0");
        this.numberJT.setHorizontalAlignment(4);
        this.numberJT.setEditable(false);
        this.numberJT.setBackground(Color.white);

        JPanel operationsJP = new JPanel(new GridLayout(6, 4));
        this.getContentPane().add(calcPanel, "North");
        this.getContentPane().add(operationsJP, "Center");
        Font displayFont = new Font("Calibri", 2, 20);

        this.numberJT.setFont(displayFont);
        this.inputJT.setFont(displayFont);

        this.num1 = new JButton("1");
        this.num1.setActionCommand("1");
        this.num2 = new JButton("2");
        this.num2.setActionCommand("2");
        this.num3 = new JButton("3");
        this.num3.setActionCommand("3");
        this.num4 = new JButton("4");
        this.num4.setActionCommand("4");
        this.num5 = new JButton("5");
        this.num5.setActionCommand("5");
        this.num6 = new JButton("6");
        this.num6.setActionCommand("6");
        this.num7 = new JButton("7");
        this.num7.setActionCommand("7");
        this.num8 = new JButton("8");
        this.num8.setActionCommand("8");
        this.num9 = new JButton("9");
        this.num9.setActionCommand("9");
        this.num0 = new JButton("0");
        this.num0.setActionCommand("0");
        this.num1.addActionListener(this);
        this.num2.addActionListener(this);
        this.num3.addActionListener(this);
        this.num4.addActionListener(this);
        this.num5.addActionListener(this);
        this.num6.addActionListener(this);
        this.num7.addActionListener(this);
        this.num8.addActionListener(this);
        this.num9.addActionListener(this);
        this.num0.addActionListener(this);

        this.operProc = new JButton("%");
        this.operProc.setActionCommand("%");
        this.operCE = new JButton("CE");
        this.operCE.setActionCommand("CE");
        this.operC = new JButton("C");
        this.operC.setActionCommand("C");
        this.operErase = new JButton("<-");
        this.operErase.setActionCommand("<-");
        this.operFraction = new JButton("1/x");
        this.operFraction.setActionCommand("1/x");
        this.operSquare = new JButton("x^2");
        this.operSquare.setActionCommand("x^2");
        this.operRoot = new JButton("sqr");
        this.operRoot.setActionCommand("sqr");
        this.operDevide = new JButton("/");
        this.operDevide.setActionCommand("/");
        this.operMultiply = new JButton("*");
        this.operMultiply.setActionCommand("*");
        this.operMinus = new JButton("-");
        this.operMinus.setActionCommand("-");
        this.operPlus = new JButton("+");
        this.operPlus.setActionCommand("+");
        this.operDot = new JButton(".");
        this.operDot.setActionCommand(".");
        this.operEarly = new JButton("=");
        this.operEarly.setActionCommand("=");
        this.operSign = new JButton("+/-");
        this.operSign.setActionCommand("+/-");
        this.operProc.addActionListener(this);
        this.operCE.addActionListener(this);
        this.operC.addActionListener(this);
        this.operErase.addActionListener(this);
        this.operFraction.addActionListener(this);
        this.operSquare.addActionListener(this);
        this.operRoot.addActionListener(this);
        this.operDevide.addActionListener(this);
        this.operMultiply.addActionListener(this);
        this.operMinus.addActionListener(this);
        this.operPlus.addActionListener(this);
        this.operDot.addActionListener(this);
        this.operEarly.addActionListener(this);
        this.operSign.addActionListener(this);

        calcPanel.add(this.inputJT);
        calcPanel.add(this.numberJT);
        //calcPanel.add(operationsJP);

        operationsJP.add(this.operProc);
        operationsJP.add(this.operCE);
        operationsJP.add(this.operC);
        operationsJP.add(this.operErase);

        operationsJP.add(this.operFraction);
        operationsJP.add(this.operSquare);
        operationsJP.add(this.operRoot);
        operationsJP.add(this.operDevide);

        operationsJP.add(this.num7);
        operationsJP.add(this.num8);
        operationsJP.add(this.num9);
        operationsJP.add(this.operMultiply);

        operationsJP.add(this.num4);
        operationsJP.add(this.num5);
        operationsJP.add(this.num6);
        operationsJP.add(this.operMinus);

        operationsJP.add(this.num1);
        operationsJP.add(this.num2);
        operationsJP.add(this.num3);
        operationsJP.add(this.operPlus);

        operationsJP.add(this.operSign);
        operationsJP.add(this.num0);
        operationsJP.add(this.operDot);
        operationsJP.add(this.operEarly);

        this.pack();
        this.setVisible(true);
        this.setDefaultCloseOperation(3);
    }
    public void actionPerformed(ActionEvent e) {
        String command = e.getActionCommand();
        switch (command){
            case "0":
                c.printStrNumber("0");
                numberJT.setText(c.getStrNumber());
                break;
            case "1":
                c.printStrNumber("1");
                numberJT.setText(c.getStrNumber());
                break;
            case "2":
                c.printStrNumber("2");
                numberJT.setText(c.getStrNumber());
                break;
            case "3":
                c.printStrNumber("3");
                numberJT.setText(c.getStrNumber());
                break;
            case "4":
                c.printStrNumber("4");
                numberJT.setText(c.getStrNumber());
                break;
            case "5":
                c.printStrNumber("5");
                numberJT.setText(c.getStrNumber());
                break;
            case "6":
                c.printStrNumber("6");
                numberJT.setText(c.getStrNumber());
                break;
            case "7":
                c.printStrNumber("7");
                numberJT.setText(c.getStrNumber());
                break;
            case "8":
                c.printStrNumber("8");
                numberJT.setText(c.getStrNumber());
                break;
            case "9":
                c.printStrNumber("9");
                numberJT.setText(c.getStrNumber());
                break;
            case "%":
                break;
            case "CE":
                break;
            case "C":
                break;
            case "<-":
                break;
            case "1/x":
                break;
            case "x^2":
                break;
            case "sqr":
                break;
            case "/":
                c.setLastOperator("/");
                break;
            case "*":
                c.setLastOperator("*");
                break;
            case "-":
                c.setLastOperator("-");
                break;
            case "+":
                c.setLastOperator("+");
                break;
            case ".":
                break;
            case "=":
                //c.addNumberHelp();
                inputJT.setText(c.getStrExample());
                numberJT.setText(c.getAnswer());
                break;
            case "+/-":
                break;
        }
    }
}
