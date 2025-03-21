//Peça ao usuário para inserir um número e diga se ele é par ou ímpar.

class EvenOrOdd
{
    static void Main() {
        string EvenOrOdd()
        {
         Console.Write("Vamos descobrir se um número é par ou impar.\nDigite um número inteiro: ");
         int number = int.Parse(Console.ReadLine()!);
        
            if(number % 2 == 0)
            {
                return $"{number} é par";
            } else
            {
            return $"{number} é ímpar";
            }
        }
        Console.WriteLine(EvenOrOdd());
    }
}