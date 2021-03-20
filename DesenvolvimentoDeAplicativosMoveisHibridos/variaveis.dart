void main() {
  //variável do tipo texto
  String nome = "Felipe Lippelt";
  int idade = 32;
  bool fumante = false; //Verdadeiro ou falso -> Booleano
  double altura = 1.83;

  print("Meu nome é $nome, eu tenho $idade anos! Tenho $altura de altura");

  var varQualquer = "Bla";
  //Var não muda de tipo após receber o primeiro valor
  dynamic varDinamica = 123;
  //dynamic muda o tipo
  varDinamica = "Bla";
}
