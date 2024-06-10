#include <stdlib.h>
#include <stdio.h>
#include <iostream>
using namespace std;
int main()
{
    int cuenta;
    char nombre[20];
    float saldo;
    FILE *ptr;

    if ((ptr = fopen("Macintosh_HD\\Usuarios\\litocordel\\Documentos\\Ficheros\\credit.dat","w"))==NULL){
    cout << "El archivo no abre";}
 
else {
    cout << "Digite la cuenta:\n ", cin >> cuenta;
    cout << "Digite el nombre: \n", cin >> nombre;
    cout << "Digitee el saldo: \n", cin >> saldo;
}
return 0;
}