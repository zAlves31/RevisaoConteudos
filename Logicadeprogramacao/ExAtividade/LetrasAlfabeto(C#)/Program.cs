Console.WriteLine("Digite um texto:");
string texto = Console.ReadLine().ToLower();

        
Dictionary<char, int> contagemLetras = new Dictionary<char, int>();

        
foreach (char c in texto)
{
    if (char.IsLetter(c)) 
    {
        if (contagemLetras.ContainsKey(c))
        {
            contagemLetras[c]++;
        }
        else
        {
            contagemLetras[c] = 1;
        }
    }
}

        
Console.WriteLine("Contagem de letras:");
foreach (var letra in contagemLetras)
{
    Console.WriteLine($"{letra.Key}: {letra.Value}");
}