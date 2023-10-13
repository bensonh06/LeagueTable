using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    // A structure is the collection of variables of different types under a single name for better handling.
    // this is a user defined type but no storage is allocated. 

    //1) Create a new public LeagueStructure that contains the teamName, points, wins and losses 		

    public struct LeagueStructure
    {
        public string teamName;
        public int points;
        public int wins;
        public int losses;

    }

    public static LeagueStructure[] leagueArray = new LeagueStructure[5];

    public static void Main()
    {
        int choice = 0;

        //2) Create an array of type "LeagueStructure" and allocate storage space for 5 "collections" in our structure.

        

        //3) Create a welcome screen and offer choices of Enter Team Information, Display League, or Exit. Store user choice



        while (true)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the league table program, please pick an option: \n");
            Console.WriteLine("1. Enter Team Information\n2. Display League\n3. Exit\n");

            string option = Console.ReadLine();

            //4) Create a switch statement that will have three cases. EnterTeam, DisplayTable, Exit.   Handle any incorrect entry.		

            switch (option)
            {
                case "1":
                    Console.Clear();
                    enterTeams();

                    break;
                case "2":
                    Console.Clear();
                    DisplayTable();

                    break;
                case "3":
                    
                    Goodbye();

                    break;
                default:
                    break;
            }
        }
    }


    static void enterTeams()
    {

        int i = 0;

        do
        {
            
            //5) loop through entering teamNames, points, wins and losses

            Console.Write("Please enter the team name: ");

            string inputTeamName = Console.ReadLine();
            leagueArray[i].teamName = inputTeamName;

            Console.Write("Please enter the team's points: ");

            int teampoints = int.Parse(Console.ReadLine());
            leagueArray[i].points = teampoints;

            Console.Write("Please enter the team's number of wins: ");

            int teamwins = int.Parse(Console.ReadLine());
            leagueArray[i].wins = teamwins;

            Console.Write("Please enter the team's number of losses: ");

            int teamLosses = int.Parse(Console.ReadLine());
            leagueArray[i].losses = teamLosses;

            if (i == 4) break;

            //6) after each team is entered as if they want to carry on adding another team

            Console.Clear();


            Console.WriteLine("Would you like to enter another team? (y/n)");

            if (Console.ReadLine() == "n")
            {
                break;
            }

            i++;

        } while (true); //(this needs to be while they want to carry on)

        Console.WriteLine("You have entered all the names, wins and points scores");
    }



    static void DisplayTable()
    {

        // 8) Loop to display teamNames, points, wins and loss on screen
        
        Console.WriteLine("        | Team Name | Points | Wins | Losses |");
        Console.WriteLine("--------+-----------+--------+------+--------+");

        //Console.ReadLine();

        for (int i = 1; i < 6; i++)
        {
            Console.WriteLine(" Team " + i + " | " + leagueArray[i-1].teamName + " | " + leagueArray[i-1].points + " | " + leagueArray[i-1].wins + " | " + leagueArray[i-1].losses + " |");
            Console.WriteLine("--------+-----------+--------+------+--------+");
        }


        // 9) Code to offer user choice to reload the main menu of the program

        Console.WriteLine("Would you like to go back to the main menu (y/n)");

        if (Console.ReadLine() == "n")
        {
            Environment.Exit(0);
        }

    }

    static void Goodbye()
    {

        //10) Exit the system
        Environment.Exit(0);


    }
}
