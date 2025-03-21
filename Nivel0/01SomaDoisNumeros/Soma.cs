using System;

class Soma
{
    static void Main() {
        Console.WriteLine("Vamos somar dois Números!\nDigite um número: ");
        int number1 = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Digite outro número: ");
        int number2 = int.Parse(Console.ReadLine()!);
        int result = number1 + number2;
        Console.WriteLine("A soma é " +  result);
    }
}


