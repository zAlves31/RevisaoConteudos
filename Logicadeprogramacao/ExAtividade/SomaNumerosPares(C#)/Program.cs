int[] vetor = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; 
int soma = 0;

for (int i = 0; i < vetor.Length; i++)
{
    if (vetor[i] % 2 == 0)
    {
        soma += vetor[i];
    }
}

Console.WriteLine($"A soma dos números pares é: {soma}");