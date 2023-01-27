using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballSquad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Football> myTeam = new List<Football>();
            myTeam.Add(new Football("Iker Casillas", "GK", 1));
            myTeam.Add(new Defanse("Sergio Ramos", "RCB", 2));
            myTeam.Add(new Defanse("Thiago Silva", "LCB", 4));
            myTeam.Add(new Defanse("Marcelo", "LB", 3));
            myTeam.Add(new Defanse("Kyle Walker", "RB", 5));
            myTeam.Add(new Midfielder("N'Golo Kante", "CDM", 8));
            myTeam.Add(new Midfielder("Paul Pogba", "CM", 6));
            myTeam.Add(new Midfielder("Kevin de Bryune", "CM", 9));
            myTeam.Add(new Forward("Lionel Messi", "RW", 10));
            myTeam.Add(new Forward("Neymar Jr.", "LW", 11));
            myTeam.Add(new Forward("Cristiano Ronaldo", "ST", 7));

            Random random = new Random();
            int kitNumber;
            Boolean possibleScore = true;
            Boolean passingPlayer = true;
            int passcontrol = 12;
            kitNumber = random.Next(1, 12);

            for (int i = 1; i <= 3; i++)
            {
                while(passcontrol == kitNumber)
                {
                    kitNumber = random.Next(1, 12);
                }
                passcontrol= kitNumber;

                if (!myTeam[kitNumber - 1].Pass())
                {
                    Console.WriteLine(kitNumber + " made a bad pass");
                    possibleScore = false;
                    break;
                }
                else
                    Console.WriteLine(kitNumber + " made a good pass");

                System.Threading.Thread.Sleep(1000);
            }

            System.Threading.Thread.Sleep(1000);

            if (passingPlayer = true)
            {
                if (myTeam[kitNumber - 1].Skill())
                    Console.WriteLine("Amazing skill");
                else
                    Console.WriteLine("Maybe he plays basic.");
            }

            System.Threading.Thread.Sleep(1000);

            if (possibleScore = true)
            {
                if (myTeam[kitNumber - 1].Shoot())
                    Console.WriteLine("Good shoot and goaaaal");
                else
                    Console.WriteLine("Bad chance");
            }
            Console.ReadLine();
        }
    }
}
