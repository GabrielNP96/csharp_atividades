// See https://aka.ms/new-console-template for more information
class PrimeNumbers
{
    public static void Main()
    {
        Console.WriteLine("Digite um número inteiro positivo: ");
        int number = int.Parse(Console.ReadLine()!);
        bool isPrime = true;

        if(number < 2)
        {
            Console.WriteLine($"{number} não é primo.");
        }else {
            for(int i = 2; i <= Math.Sqrt(number); i++ )
            {
                if(number % i == 0)
                {
                    isPrime = false;
                    break;
                } 
            }
        }

        if(isPrime)
        {
            Console.WriteLine($"{number} é primo");
        } else
        {
            Console.WriteLine($"{number} não é primo.");
        }
    }
}
