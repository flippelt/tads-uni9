#include <stdio.h>
#include <conio.h>
#include <locale.h>

int main(){
    setlocale(LC_ALL, "Portuguese");

    printf("Nome Sobrenome\nAv.Qualquer Coisa, 9080\nBairro 00000-001");
    
    getch();
    return 0;
}
