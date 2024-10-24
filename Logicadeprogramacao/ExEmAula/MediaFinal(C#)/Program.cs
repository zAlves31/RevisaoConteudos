Console.WriteLine($" Insira sua Nota 1");
double Nota1 =Convert.ToDouble(Console.ReadLine());

Console.WriteLine($" Insira sua Nota 2");
double Nota2 =Convert.ToDouble(Console.ReadLine());

Console.WriteLine($" Insira sua Nota 3");
double Nota3 =Convert.ToDouble(Console.ReadLine());

Console.WriteLine($" Insira sua Nota 4");
double Nota4 =Convert.ToDouble(Console.ReadLine());


double MediaFinal = ((Nota1 + Nota2 + Nota3 + Nota4 ) / 4);


if (MediaFinal <= 5)
{ 
     Console.WriteLine($"Sua media foi {MediaFinal}, Aluno reprovado 😔");
}
else if (MediaFinal >= 6)
{
    Console.WriteLine($"Sua media foi {MediaFinal}, Aluno aprovado 😀");   
}


