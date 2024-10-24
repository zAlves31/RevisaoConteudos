string[] nomes = new string[5];

        
for (int i = 0; i < nomes.Length; i++)
{
    Console.Write("Digite o nome {0}: ", i + 1);
    nomes[i] = Console.ReadLine();
}
        
for (int i = 0; i < nomes.Length - 1; i++)
{
    for (int j = 0; j < nomes.Length - 1 - i; j++)
    {
        if (string.Compare(nomes[j], nomes[j + 1]) > 0)
        {
                    
            string temp = nomes[j];
            nomes[j] = nomes[j + 1];
            nomes[j + 1] = temp;
        }
    }
}

Console.WriteLine("\nNomes cadastrados em ordem alfabética:");
foreach (string nome in nomes)
{
    Console.WriteLine(nome);
}
    


