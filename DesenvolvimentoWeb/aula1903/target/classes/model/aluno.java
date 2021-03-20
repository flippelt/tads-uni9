package DesenvolvimentoWeb.aula1903.target.classes;

public class Aluno{
    private String nome;
    private float n1;
    private float n2;
    private float media;
    private String Situacao;

    public String getNome(){
        return nome;
    }
    public void setNome(String nome){
        this.nome = nome;
    }
    public float getN1(){
        return n1;
    }
    public void setN1(float n1){
        this.n1 = n1;
    }
    public float getN2(){
        return n2;
    }
    public void setN2(float n2){
        this.n2 = n2;
    }
    public float getMedia(){
        return media;
    }
    public void calcMedia(){
        calcMedia(this.n1, this.n2);
    }
    public void calcMedia(float n1, float n2){
        this.media = (this.n1 + this.n2) / 2;
        this.Situacao = (this.media < 6) ? "Reprovado" : "Aprovado";

    }
    public String getSituacao(){
        return Situacao;
    }
}