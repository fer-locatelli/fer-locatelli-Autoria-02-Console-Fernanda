// See https://aka.ms/new-console-template for more information

               // VERIFICADOR DE FAIXA ETÁRIA //
Console.WriteLine("Digite a sua idade:");
int idade = int.Parse(Console.ReadLine());

if (idade >= 0 && idade <= 12)
{
    Console.WriteLine("Você é uma criança.");
}
else if (idade >= 13 && idade <= 17)
{
    Console.WriteLine("Você é um adolescente.");
}
else if (idade >= 18 && idade <= 59)
{
    Console.WriteLine("Você é um adulto.");
}
else if (idade >= 60)
{
    Console.WriteLine("Você é um idoso.");
}
else
{
    Console.WriteLine("Idade inválida!");
}