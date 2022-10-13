

import java.awt.Color;
import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.math.BigDecimal;
import java.text.SimpleDateFormat;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JTextField;


/**
 * @author guo
 * 656530548@qq.com
 *
 */
public class MyCalculator extends JFrame{
    //�����ж��Ƿ����¿�ʼ
    private boolean start = true;
    private double result = 0;
    //��żӼ��˳����ڵ�
    private String command = "=";
    private JTextField jTextField;
    private JPanel jPanel = new JPanel();
    private JButton[] jButtons;

    //�ù��췽�����б�Ҫ������
    public MyCalculator() {

        this.setTitle("��ѧ������");
        this.setSize(600, 300);
        this.setLocationRelativeTo(null);

        //�����ı���
        jTextField = new JTextField(30);
        jTextField.setText("");
        jTextField.setEditable(true);
        this.add(jTextField,"North");

        //���Ӱ�ť
        jPanel.setLayout(new GridLayout(5,7,3,3));
        String name[] = {
                "+/-","PI","1/X","C","/","*","Back","X^2","X^3",
                "X^y","7","8","9","-","X!","��X","3^��X","4","5",
                "6","+","sin","cos","tan","1","2","3","%",
                "2����","10����","cot","time","0",".","="
        };
        jButtons = new JButton[name.length];
        MyActionListener actionListener= new MyActionListener();

        //����ѭ��������ť���������¼�������
        for(int i = 0; i < name.length; i++) {

            jButtons[i] = new JButton(name[i]);
            jButtons[i].addActionListener(actionListener);

            //���ð�ť������ɫ
            jButtons[i].setBackground(Color.lightGray);
            if(name[i].equals("="))
                jButtons[i].setBackground(Color.RED);
            else if((int)name[i].charAt(0)>=48 && (int)name[i].charAt(0)<=57
                    && name[i].length() == 1)
                jButtons[i].setBackground(Color.WHITE);
            else if(name[i].equals("Back"))
                jButtons[i].setBackground(Color.GRAY);

            jPanel.add(jButtons[i]);
        }

        this.add(jPanel);
        this.setDefaultCloseOperation(EXIT_ON_CLOSE);
        this.setVisible(true);

    }

    //���ڲ���ʵ���¼�������
    class MyActionListener implements ActionListener{
        //��ť������
        public void actionPerformed(ActionEvent e) {

            String input = e.getActionCommand();
            //��ʼ
            if(start) {
                if((int)input.charAt(0)>=48 && (int)input.charAt(0)<=57
                        && input.length() == 1 ) {
                    jTextField.setText(""+input);
                }
                if(input.equals("+/-")) {
                    jTextField.setText("-");
                }
                if(input.equals("PI")) {
                    jTextField.setText(""+Math.PI);
                }
                start = false;
                if(input.equals("C"))
                    jTextField.setText("");
            }
            //0~9���ֵȷ������
            else if((int)input.charAt(0)>=48 && (int)input.charAt(0)<=57
                    && input.length() == 1 || input.equals(".")){
                jTextField.setText(jTextField.getText()+input);
            }
            //ʵ������ ����+����� ������

            //ʵ�������
            else if(input.equals("C"))
                jTextField.setText("");
                //ʵ���˸��
            else if(input.equals("Back")) {
                if(jTextField.getText().length() > 0){
                    jTextField.setText(jTextField.getText().substring(0,jTextField.getText().length()-1));
                }
            }
            //ʵ���������Ǻ���
            else if(input.equals("sin")) {
                result = Math.sin(Double.parseDouble(jTextField.getText()));
                jTextField.setText(""+getPrettyNumber(Double.toString(result)));
                start = true;
            }
            //ʵ���������Ǻ���
            else if(input.equals("cos")) {
                result = Math.cos(Double.parseDouble(jTextField.getText()));
                jTextField.setText(""+getPrettyNumber(Double.toString(result)));
                start = true;
            }
            //ʵ���������Ǻ���
            else if(input.equals("cot")) {
                result = 1.0/Math.tan(Double.parseDouble(jTextField.getText()));
                jTextField.setText(""+getPrettyNumber(Double.toString(result)));
                start = true;
            }
            //ʵ���������Ǻ���
            else if(input.equals("tan")) {
                result = Math.tan(Double.parseDouble(jTextField.getText()));
                jTextField.setText(""+getPrettyNumber(Double.toString(result)));
                start = true;
            }
            //ʵ��ʮ���Ƶ������Ƶ�ת��
            else if(input.equals("2����")) {
                String result2 = Integer.toBinaryString(Integer.parseInt(jTextField.getText()));
                jTextField.setText(""+getPrettyNumber(result2));
                start = true;
            }
            //ʵ�ֶ����Ƶ�ʮ���Ƶ�ת��
            else if(input.equals("10����")) {
                try {
                    String result2 = Integer.valueOf(jTextField.getText(),2).toString();
                    jTextField.setText(""+getPrettyNumber(result2));
                }catch(NumberFormatException exception) {
                    JOptionPane.showMessageDialog(null, "�Բ������ִ������������룡", "Error!", JOptionPane.ERROR_MESSAGE);
                    throw new NumberFormatException("���ָ�ʽ����");
                }finally {
                    start = true;
                }

            }
            //ʵ��1/x
            else if(input.equals("1/X")) {
                result = 1 / Double.parseDouble(jTextField.getText());
                jTextField.setText(""+getPrettyNumber(Double.toString(result)));
                start = true;
            }
            //ʵ��ƽ������
            else if(input.equals("X^2")) {
                result = Math.pow(Double.parseDouble(jTextField.getText()), 2);
                jTextField.setText(""+getPrettyNumber(Double.toString(result)));
                start = true;
            }
            //ʵ����������
            else if(input.equals("X^3")) {
                result = Math.pow(Double.parseDouble(jTextField.getText()), 3);
                jTextField.setText(""+getPrettyNumber(Double.toString(result)));
                start = true;
            }
            //ʵ�ֽ׳�
            else if(input.equals("X!")) {
                if(Double.parseDouble(jTextField.getText()) < 0) {
                    JOptionPane.showMessageDialog(null, "�Բ��𣬽׳˼��㲻��Ϊ����", "Error!", JOptionPane.ERROR_MESSAGE);
                    jTextField.setText("�Բ��𣬽׳˼��㲻��Ϊ����");
                    start = true;
                    throw new IllegalArgumentException("�׳˼�����ָ���");
                }else {
                    int sum;
                    sum = factorial(Integer.parseInt(jTextField.getText()));
                    jTextField.setText(Integer.toString(sum));
                    start = true;
                }

            }
            //ʵ�ְٷֺż���
            else if(input.equals("%")) {
                result = Double.parseDouble(jTextField.getText())/ 100.0;
                jTextField.setText(""+getPrettyNumber(Double.toString(result)));
                start = true;
            }
            //ʵ�ֿ�ƽ����
            else if(input.equals("��X")) {
                result = Math.sqrt(Double.parseDouble(jTextField.getText()));
                jTextField.setText(""+getPrettyNumber(Double.toString(result)));
                start = true;
            }
            //ʵ�ֿ�������
            else if(input.equals("3^��X")) {
                result = Math.pow(Double.parseDouble(jTextField.getText()),1.0/3);
                jTextField.setText(""+getPrettyNumber(Double.toString(result)));
                start = true;
            }
            //ʵ�ֻ�ȡ��ǰʱ��
            else if(input.equals("time")) {
                SimpleDateFormat df = new SimpleDateFormat("yyyy-MM-dd HH:mm:ss");
                jTextField.setText(df.format(System.currentTimeMillis()));
                start = true;
            }

            //ʵ�ּӼ��˳��� ����+�����+���� ��ʽ������
            else {
                if(!start) {

                    if(command.equals("+"))
                        result += Double.parseDouble(jTextField.getText());
                    else if(command.equals("-"))
                        result -= Double.parseDouble(jTextField.getText());
                    else if(command.equals("*"))
                        result *= Double.parseDouble(jTextField.getText());
                    else if(command.equals("/")) {
                        if(Double.parseDouble(jTextField.getText()) != 0) {
                            result /= Double.parseDouble(jTextField.getText());
                        }else {
                            jTextField.setText(""+"�Բ��𣬳�������Ϊ��");
                            JOptionPane.showMessageDialog(null, "�Բ��𣬳�������Ϊ��", "Error!", JOptionPane.ERROR_MESSAGE);
                            command = "=";
                            start = true;
                            throw new ArithmeticException("����Ϊ��");
                        }

                    }
                    else if(command.equals("="))
                        result = Double.parseDouble(jTextField.getText());

                    else if(command.equals("X^y"))
                        result = Math.pow(result, Double.parseDouble(jTextField.getText()));
                    jTextField.setText(""+getPrettyNumber(Double.toString(result)));
                    command = input;
                    start = true;
                }
            }
        }
    }
    //ȥ��С�����û�õ�0
    public static String getPrettyNumber(String number) {
        return BigDecimal.valueOf(Double.parseDouble(number))
                .stripTrailingZeros().toPlainString();
    }
    //��ѭ������׳�
    public static int factorial(int num) {
        int sum = 1;
        for(int i = 1;i <= num; i++){
            sum *= i;
        }
        return sum;
    }

    public static void main(String[] args) {
        MyCalculator myCalculator = new MyCalculator();

    }

}
