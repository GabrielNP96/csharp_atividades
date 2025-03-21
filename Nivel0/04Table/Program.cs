//Peça ao usuário para digitar um número e exiba a tabuada desse número até o 10.

using System.Globalization;

class Table
{
    static void Main()
    {
        Console.WriteLine("Digite um número inteiro positivo e vou te fornecer a tabuada dele de soma: ");
        int number = int.Parse(Console.ReadLine()!);

        for(int i = 0; i <= 10; i++)
        {
            Console.WriteLine($"{number} + 1 = {number + i}");
        }
        
    }
}