Console.WriteLine("Digite o número da tabuada que você quer ver:");
    
int numero = int.Parse(Console.ReadLine());

Console.WriteLine("Tabuada do " + numero + ":");

for (int j = 1; j <= 10; j++)
{
    Console.WriteLine(numero + " x " + j + " = " + (numero * j));
}