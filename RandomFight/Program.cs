using System;

namespace RandomFight
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables are decleared here
            int fighter1 = 100;
            int fighter2 = 100;

            //Random number generator, Randomizes damage
            Random damage = new Random();

            //Initial information about what the user should do
            System.Console.WriteLine("Fight to the Death!!!\nWho do you think will win the fight?\nPress ENTER To Begin The Fight!");

            Console.ReadLine();

            //While-loop that runs as long as both fighters have HP left
            while (fighter1 >= 0 && fighter2 >= 0)
            {
                int damage1 = damage.Next(1, 21);
                int damage2 = damage.Next(1, 21);

                fighter1 -= damage2;
                fighter2 -= damage1;

                System.Console.WriteLine("Fighter 1 Attacks Fighter 2 for " + damage1 + " Damage! Fighter 2 HP is now: " + fighter2);
                System.Console.WriteLine("Fighter 2 Attacks Fighter 1 for " + damage2 + " Damage! Fighter 1 HP is now: " + fighter1);

                System.Console.WriteLine("Press ENTER To Continue");
                Console.ReadLine();

            }



            //If-statements that tells the user who won the fight

            if (fighter1 <= 0 && fighter2 <= 0)
            {
                System.Console.WriteLine("It's A Draw!");
            }

            else if (fighter1 <= 0)
            {
                System.Console.WriteLine("Fighter 1 Lost! Fighter 2 Is The Winner!");
            }

            else if (fighter2 <= 0)
            {
                System.Console.WriteLine("Fighter 2 Lost! Fighter 1 Is The Winner!");
            }


            //Writeline that tells the user to exit
            System.Console.WriteLine("Press ENTER To Exit");

            Console.ReadLine();
        }
    }
}
