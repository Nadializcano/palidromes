using System;
using System.Linq;

class Palindromes
{
  static void Main()
  {
    Console.WriteLine("Write a word to see if its a Palindrome");
    string inputWord = Console.ReadLine();
    char[] myArray = inputWord.ToArray();
    // Console.WriteLine(myArray);

    char[] myNewArray = new char[6];

    Array.Copy( myArray, myNewArray, 6);

    Array.Reverse(myNewArray);

    // Console.WriteLine(myNewArray);

    Console.WriteLine(myArray);

    bool isEqual = Enumerable.SequenceEqual(myArray, myNewArray);
    Console.WriteLine(isEqual); 
  }
}
