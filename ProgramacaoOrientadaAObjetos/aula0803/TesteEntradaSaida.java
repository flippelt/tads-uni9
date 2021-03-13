
import javax.swing.JOptionPane;


public class TesteEntradaSaida {
    public static void main(String[] args) {
        
        //entrada
        String entrada = JOptionPane.showInputDialog("Digite seu nome");
         
        //instrucoes = logica do programa
        String entradaMaisculo = entrada.toUpperCase();
        
        //juntar string é com o operador +
        String mensagem = "O seu nome em maisculo é " + entradaMaisculo + "!";
        
        
        //saida
        JOptionPane.showMessageDialog(null, mensagem);
    }
}
