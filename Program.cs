using System;

class Program
{
  
    public static void Main() 
    {

    int Quarter = 25;
   int Dime = 10;
   int Nickel = 5;
   int Pennies = 1;
    int QuarterNum = 0;
   int DimeNum = 0;
   int NickelNum = 0;
   int PenniesNum = 0;
   
        // List<string> Change = new List <string>();

        Console.WriteLine("Input a number of cents to give change for.");
        int Input = int.Parse(Console.ReadLine());

        Console.WriteLine("Initial input is " + Input + " cents");

        while(Input >= Quarter)
        {
            Input -= Quarter;
            QuarterNum ++;
        }
        while(Input >= Dime)
        {
            Input -= Dime;
            DimeNum ++;
        }
        while(Input >= Nickel)
        {
            Input -= Nickel;
            NickelNum ++;
        }
        while(Input >= Pennies)
        {
            Input -= Pennies;
            PenniesNum ++;
        }

        Console.WriteLine("You should give back " + QuarterNum + " quarters, " + DimeNum + " dimes, " + NickelNum + " nickels, " + PenniesNum + " pennies.");
    }
}