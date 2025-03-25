using System;

class VowelCounter
{
    public static void Main()
    {
        int numberOfVowel = 0;
        Console.WriteLine("Digite um palavra ou frase: ");
        string userWord = Console.ReadLine()!;

        List<char> words = new List<char>(userWord.ToLower().Replace(" ", "").ToCharArray());
        foreach(char letters in words)
        {
            switch(letters)
            {
                case 'a':
                    numberOfVowel += 1;
                    break;
                case 'e':
                    numberOfVowel += 1;
                    break;
                case 'i':
                    numberOfVowel += 1;
                    break;
                case 'o':
                    numberOfVowel += 1;
                    break;
                case 'u':
                    numberOfVowel += 1;
                    break;
                default:
                    break;
                
            }
        }

        Console.WriteLine($"{userWord} tem {numberOfVowel} vogais");

        
    }
}
