//Solicite ao usuário um número e faça uma contagem regressiva até 0.
class Countdown
{
    static void Main()
    {
        Console.WriteLine("Digite um número inteiro positivo para realizar a contagem regressiva: ");
        int userNumber = int.Parse(Console.ReadLine()!);
        for(int i = userNumber; i >= 0; i--)
        {
            Console.WriteLine(i);
        }
    }
}
