int contador = 1;
int soma = 0;

while(contador <= 100 )
{
    if(contador % 2 == 0 ){

        soma += contador;
    }
    contador++;

}

Console.WriteLine($"{soma}");