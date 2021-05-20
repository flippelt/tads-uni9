/*
comentários de multiplas linhas

*/


// comentário de uma linha
public class Testes {
    
    public static void main(String[] args) {
        
        //instruções...
        String msg = "Olá, mundo!"; //variável objeto
        
        //numeros
        int numeroInteiro = 10;  //variável não-objeto
        double numeroDecimais = 10.3; //variável não-objeto
        
        //coverter o objeto msg para uma versao maiuscula
        String msgMaiusculo = msg.toUpperCase();
     
        System.out.println(msg);
        System.out.println(msgMaiusculo);
     
        //obter o primeiro caracteres do objeto msg
        char caracteres = msgMaiusculo.charAt(0);
        System.out.println(caracteres);
        
        
        
        String outra = "Olá, mundo!"; 
        System.out.println( outra.toUpperCase() );
        System.out.println( outra );
        
        
    }
    
}
