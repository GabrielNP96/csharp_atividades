﻿using System;

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
                case 'a': case 'e':  case 'i': case 'o': case 'u':
                    numberOfVowel += 1;
                    break;
                default:
                    break;
                
            }
        }

        Console.WriteLine($"{userWord} tem {numberOfVowel} vogais");

        
    }
}
