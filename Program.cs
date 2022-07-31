// Exercício do site URI "Soma pares consecutivos"
// Neste aplicativo o usuário irá digitar números inteiros até que seja digitado "0",
// A partir do numero dogitado o programa somara os priximos 5 números pares, trazendo no final a soma deles.

int Soma;

int x = int.Parse(Console.ReadLine());

while (x != 0)
{
    // se for impar, some mais 1
    if (x % 2 != 0)
    {
        x = x + 1;
    }
    // expressao simplificada: 5 * x + 20
    int soma = x + x + 2 + x + 4 + x + 6 + x + 8;
    Console.WriteLine(soma);

    x = int.Parse(Console.ReadLine());
}