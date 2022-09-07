using System;
using System.Collections.Generic;
namespace ShootingDice
{
    // TODO: Complete this class

    // A player the that prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
            public override int Roll()
        {
            // Return a random number between 1 and DiceSize
            Console.WriteLine("Input a number");
            int humanNumber = int.Parse(Console.ReadLine());
            return humanNumber;
        }
    }
}