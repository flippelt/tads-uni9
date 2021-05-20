#include <stdio.h>
#include <conio.h>
#include <locale.h>

int main(){
    setlocale(LC_ALL, "Portuguese");

    float x, y, soma;
    

    printf("Digite o primeiro número: ");
    scanf ("%f", &x);
    printf("Digite o segundo número: ");
    scanf ("%f", &y);
    soma = x + y;
    printf("A soma é: %.2f", soma);

    getch();
    return 0;
}
