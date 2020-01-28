
using System;

namespace ProUDontOwnMe
{
    class Program
    {
        static void Main(string[] args)
        {
            BoostMushroom myBoostMushroom = new BoostMushroom();
            RedShell myRedShell = new RedShell();
            SuperFeather mySuperFeather = new SuperFeather();
            string input = "";
            Console.Clear();
            Console.WriteLine("welcome on the Mario Kart 'item wiki'!");
            Console.WriteLine("choose: 'Boost Mushroom', 'Red Shell' or 'Super Feather'");
            input = Console.ReadLine();
            
            if(input == "Boost Mushroom")
            {
                Console.WriteLine("you choose the Boost Mushroom");
                myBoostMushroom.resetTimer();
                myBoostMushroom.canBePickedUp();
                myBoostMushroom.speed();
                myBoostMushroom.invinciblity();
                myBoostMushroom.duration();
            }
            else if(input == "Red Shell")
            {
                Console.WriteLine("you choose the Red Shell");
                myRedShell.resetTimer();
                myRedShell.canBePickedUp();
                myRedShell.speed();
                myRedShell.ability();
                myRedShell.duration();
            }
            else if(input == "Super Feather")
            {
                Console.WriteLine("you choose the Super Feather");
                mySuperFeather.resetTimer();
                mySuperFeather.canBePickedUp();
                mySuperFeather.speed();
                mySuperFeather.jump();
                mySuperFeather.boost();
            }
            else
            {
                Console.WriteLine("sorry but: "+input+" does not excist.");
                
            }
        }
    }
}

