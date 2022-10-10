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


    Calculator(){
        this.setTitle("Калькулятор (Лаба 5)");
        this.setSize(500, 400);
        Container c = this.getContentPane();
        c.setLayout(new BorderLayout());

        JPanel calcPanel = new JPanel(new GridLayout(3, 1));
        this.getContentPane().add(calcPanel, "North");

        // Пример
        this.inputJT = new JTextField("");
        this.inputJT.setHorizontalAlignment(4);
        this.inputJT.setEditable(false);
        this.inputJT.setBackground(Color.white);

        // Пример
        this.numberJT = new JTextField("");
        this.numberJT.setHorizontalAlignment(4);
        this.numberJT.setEditable(false);
        this.numberJT.setBackground(Color.white);

        JPanel oprationsJP = new JPanel(new GridLayout(6, 4));
        this.getContentPane().add(oprationsJP, "Center");
        Font displayFont = new Font("Calibri", 2, 20);

        this.numberJT.setFont(displayFont);
        this.inputJT.setFont(displayFont);



        this.num1 = new JButton("1");
        this.num2 = new JButton("2");
        this.num3 = new JButton("3");
        this.num4 = new JButton("4");
        this.num5 = new JButton("5");
        this.num6 = new JButton("6");
        this.num7 = new JButton("7");
        this.num8 = new JButton("8");
        this.num9 = new JButton("9");
        this.num0 = new JButton("0");
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
        this.operCE = new JButton("CE");
        this.operC = new JButton("C");
        this.operErase = new JButton("<-");
        this.operFraction = new JButton("1/x");
        this.operSquare = new JButton("x^2");
        this.operRoot = new JButton("sqr");
        this.operDevide = new JButton("/");
        this.operMultiply = new JButton("*");
        this.operMinus = new JButton("-");
        this.operPlus = new JButton("+");
        this.operDot = new JButton(".");
        this.operEarly = new JButton("=");
        this.operSign = new JButton("+/-");
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
        calcPanel.add(oprationsJP);

        oprationsJP.add(this.operProc);
        oprationsJP.add(this.operCE);
        oprationsJP.add(this.operC);
        oprationsJP.add(this.operErase);

        oprationsJP.add(this.operFraction);
        oprationsJP.add(this.operSquare);
        oprationsJP.add(this.operRoot);
        oprationsJP.add(this.operDevide);

        oprationsJP.add(this.num7);
        oprationsJP.add(this.num8);
        oprationsJP.add(this.num9);
        oprationsJP.add(this.operMultiply);

        oprationsJP.add(this.num4);
        oprationsJP.add(this.num5);
        oprationsJP.add(this.num6);
        oprationsJP.add(this.operMinus);

        oprationsJP.add(this.num1);
        oprationsJP.add(this.num2);
        oprationsJP.add(this.num3);
        oprationsJP.add(this.operPlus);

        oprationsJP.add(this.operSign);
        oprationsJP.add(this.num0);
        oprationsJP.add(this.operDot);
        oprationsJP.add(this.operEarly);

        this.pack();
        this.setVisible(true);
        this.setDefaultCloseOperation(3);
    }
    public void actionPerformed(ActionEvent e) {
        int a = 0;
    }
}
