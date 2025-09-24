// See https://aka.ms/new-console-template for more information

             // CALCULANDO COSSENO PELO TRIANGULO //

Console.WriteLine("=== Cálculo do Cosseno pelo Triângulo ===");
Console.WriteLine("Escolha o ângulo que deseja calcular:");
Console.WriteLine("1 - Ângulo A");
Console.WriteLine("2 - Ângulo B");
Console.WriteLine("3 - Ângulo C");

int opcao = int.Parse(Console.ReadLine());

// Entrada dos lados do triângulo
Console.Write("Digite o valor do lado a: ");
double a = double.Parse(Console.ReadLine());

Console.Write("Digite o valor do lado b: ");
double b = double.Parse(Console.ReadLine());

Console.Write("Digite o valor do lado c: ");
double c = double.Parse(Console.ReadLine());

double cos = 0;

switch (opcao)
{
    case 1: // Ângulo A
        cos = (b * b + c * c - a * a) / (2 * b * c);
        Console.WriteLine($"cos(A) = {cos:F4}");
        break;

    case 2: // Ângulo B
        cos = (a * a + c * c - b * b) / (2 * a * c);
        Console.WriteLine($"cos(B) = {cos:F4}");
        break;

    case 3: // Ângulo C
        cos = (a * a + b * b - c * c) / (2 * a * b);
        Console.WriteLine($"cos(C) = {cos:F4}");
        break;

    default:
        Console.WriteLine("Opção inválida!");
        break;
}