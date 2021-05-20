import javax.swing.JOptionPane;

public class ex03 {
    public static void main(String[] args) {
        String name = JOptionPane.showInputDialog("Qual é seu nome?");
        System.out.println("Olá " + name);
        System.exit(0);
    }
}