using System;
using System.Collections.Generic;


public class Program
{
  public static void Main()
  {
    Console.WriteLine("Enter a word");
    string userInput = Console.ReadLine();
    char[] array = userInput.ToCharArray();
    for (int i = 0; i < array.Length; i++)
      {
          char letter = array[i];
          Console.WriteLine(letter);
      }
      char[] reverseArray = userInput.ToCharArray();
      Array.Reverse(reverseArray);
      string compare = new string(reverseArray);

      if (userInput == compare)
      {
        Console.WriteLine("This word is a palindrome!");
      }
      else
      {
        Console.WriteLine("This word is not a palindrome!");
      }
    }
  }
