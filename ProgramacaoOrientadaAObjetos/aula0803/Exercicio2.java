
import javax.swing.JOptionPane;

/*
Faça um programa que, a partir de uma string digitada pelo usuário, imprima: 
    1. O número de caracteres da string. Use o método lenght()
    2. A string com todas suas letras em maiúsculo. Use o método toUpperCase()
    3. A string com todas suas letras em minusculo. Use o método toLowerCase()
    4. A string sem caracteres em brancos início. Use o método trim()
*/

public class Exercicio2 {
    
    public static void main(String[] args) {
        
        String entrada = JOptionPane.showInputDialog("Digite uma frase");
        
        
        int quantCaracteres = entrada.length();
        String resposta1 = "A quantidade de caracteres é " + quantCaracteres;
        System.out.println(resposta1);
        
        System.out.println(entrada.toLowerCase());
        System.out.println(entrada.toUpperCase());
        System.out.println(entrada.trim());
        
    }
    
    
}
