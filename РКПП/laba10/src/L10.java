import java.awt.*;
import java.awt.event.*;
import java.awt.geom.*;
import java.util.Random;
import javax.swing.*;

public class L10 extends JPanel {
    public L10() {
        JFrame fr=new JFrame("Вращение линии");
        fr.setPreferredSize( new Dimension(320,320));
        final JPanel pan= new JPanel();
        fr.add(pan);
        fr.setVisible(true);
        fr.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        fr.pack();
        Timer tm= new Timer(50, new ActionListener(){
            int i=0;
            @Override
            public void actionPerformed(ActionEvent arg0) {
                Graphics2D gr=(Graphics2D)pan.getRootPane().getGraphics();
                pan.update(gr);
                GeneralPath path = new GeneralPath();
                path.append(new Polygon(new int []{150,30},new int[]{150,150},2),true);
                int x=150,y=150;
                //gr.translate(100, 100);
                AffineTransform tranforms = AffineTransform.getRotateInstance(i++ * 0.005, x, y);
                int a = (int) (Math.random() * 255);
                int b = (int) (Math.random() * 255);
                int c = (int) (Math.random() * 255);
                Color newColor = new Color(a, b, c);
                gr.setColor(newColor);
                gr.transform(tranforms);
                gr.draw(path);
            }});
        tm.start();
    }
}
