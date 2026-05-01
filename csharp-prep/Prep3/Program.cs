using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {

        Random randomGenerator = new Random();
        int magicNum =  randomGenerator.Next(1,100);
        int guess=0;
        string guessWord;
        Console.WriteLine("Guess a number");
        while(guess!=magicNum)
        {
           guessWord= Console.ReadLine();
           guess=int.Parse(guessWord);

           if(guess>magicNum)
            {
                Console.WriteLine("too high, guess again");

            }
            else if(guess<magicNum)
            {
               Console.WriteLine("too low, guess again"); 

            }
            else
            {
                Console.WriteLine("Correct");
            }



        }

        


    }
}