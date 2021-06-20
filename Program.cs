using System;
using System.Collections.Generic;

namespace liststask3
{
    class Program
    {
        static void Main(string[] args)
        {
            {
    string answer;
    List<int> numList = new List<int>();
    Console.WriteLine("Rolling a dice...");
    Random rand1 = new Random();
    int diceNum1 = rand1.Next(1, 7);
    numList.Add(diceNum1);
    Console.WriteLine("You rolled a " + diceNum1);
    if (diceNum1 < 7)
    Console.WriteLine("Continue to roll a dice? (y/n)");
    answer = Console.ReadLine();
    while (answer != "n")
    {
        Random rand2 = new Random();
        int diceNum2 = rand1.Next(1, 7);
        Console.WriteLine("You rolled a " + diceNum2);
        Console.WriteLine("Continue to roll the dice? (y/n)");
        numList.Add(diceNum2);
        answer = Console.ReadLine();
    }
    Console.WriteLine("Enter amount of rolls to examine:"); 
    int rolls = int.Parse(Console.ReadLine()); 

    Console.Write("Rolls were: ");
    int total = 0;
    for(int i = 0; i < rolls; i++)
    {
        Console.Write(numList[i] + " ");
        total += numList[i];
    }
    double avg = (double)total / rolls;
    double avgc = Math.Round((double)avg, 2);
    Console.WriteLine("");
    Console.WriteLine("Total is: " + total);
    Console.WriteLine("Average is: " + avgc);
            }
        }
    }
}