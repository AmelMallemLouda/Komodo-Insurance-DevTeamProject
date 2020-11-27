using DevTeamsProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeam_Console
{
    public class ProgramUI
    {
        private DeveloperRepo _DevList = new DeveloperRepo();
        public void Run()
        {
            Menu();
        }

        private void Menu()

        {
            bool keepRunning = true;
            while (keepRunning)
            {




                // Display our option to the user

                Console.WriteLine("Selecte a menu option:\n" +
                    "1.Create a new Team \n" +
                    "2.Add developpers individually from the developer directory to that team\n" +
                    "3.See a list of existing developers\n" +
                    "4.Add members to a team by their unique identifier\n" +
                    "5.Remove members from a team by their unique identifier\n" +
                    "6.Get a list of all the Developers that need a Pluralsight license monthly\n" +
                    "7.Add multiple Developers to a team at once\n");
                //Get the user input

                string input = Console.ReadLine();

                //Evaluate user's input and act accordingly

                Console.Clear();

                switch (input)

                {

                    case "1":
                        CreateNewTeam();
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                    case "6":
                        break;
                    case "7":
                        break;
                    case "8":
                        Console.WriteLine("Exit");
                        break;
                   keepRunning = false;

                    default:
                        Console.WriteLine("please enter a correct number");
                        break;
                }
                Console.WriteLine("Please press any key to continue");
                Console.ReadKey();
                Console.Clear();
            }
        }
        //Create  a new Team 
        public void CreateNewTeam()
        {
            DevTeam newTeam = new DevTeam();

            //Name
            Console.WriteLine("Enter the name of the new Team");
            newTeam.Name = Console.ReadLine();

            //TeamID

            Console.WriteLine("Enter the ID of the Team" );
            string idAsString = Console.ReadLine();
            newTeam.TeamId = int.Parse(idAsString);

            // Developers within the team
            Console.WriteLine("Enter the developers of the team");
            newTeam.DevelopersOfTeam = Console.ReadLine();
        }

    }
}