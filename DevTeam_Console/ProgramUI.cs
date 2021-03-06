﻿using DevTeamsProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeam_Console
{
    public class ProgramUI
    {
        public DeveloperRepo _DevList = new DeveloperRepo();
        public DevTeamRepo _Team = new DevTeamRepo();
        public DevTeam devTeam = new DevTeam();
        public List<DevTeam> teamList = new List<DevTeam>();
        public List<DeveloperInfo> developer = new List<DeveloperInfo>();

        public void Run()
        {
            SeedDeveloperList();
            SeedTeamList();
            Menu();
        }

        private void Menu()

        {
            bool keepRunning = true;
            while (keepRunning)
            {


                // Display our option to the user

                Console.WriteLine("Selecte a menu option:\n" +
                    "1.Create a new Team. \n" +
                    "2.See a list of existing teams and existing developers.\n" +
                    "3.Add members to a team by their unique identifier.\n" +
                    "4.Remove members from a team by their unique identifier.\n" +
                    "5.See whether or not the developers have access to the online learning tool: Pluralsight.\n" +
                    "6.Add multiple Developers to a team at once.\n" +
                    "7.Exist.\n");


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
                        DisplayListOfDevelopers();
                        Console.WriteLine("Press any key to see the existing teams");
                        Console.ReadLine();
                        DisplayListOfTeams();
                        break;
                    case "3":
                        AddDevelopersToTeams();
                        break;
                    case "4":
                        RemovedevelopersFromTeam();

                        break;
                    case "5":
                        HasAccessToPluralSight();
                        break;
                    case "6":
                        AddMultipleDevelopersToTeam();
                        break;
                    case "7":
                        Console.WriteLine("GoodBye");
                        keepRunning = false;
                        break;

                    default:
                        Console.WriteLine("Please enter a correct number.");
                        break;

                  
                }

  
                Console.ReadLine();
                Console.Clear();
            }
        }
        //Create  a new Team 
        public void CreateNewTeam()
        {
            DevTeam newTeam = new DevTeam();

            //Name
            Console.WriteLine("Enter the name of the new Team.");
            newTeam.Name = Console.ReadLine();

            //TeamID

            Console.WriteLine("Enter the ID of the new Team.(1,2,3,4)");
            newTeam.TeamId = int.Parse(Console.ReadLine());


            _Team.AddTeamToList(newTeam);

        }


        public void AddDevelopersToTeams()

        {
            DeveloperInfo developer = new DeveloperInfo();
           
            // Find Team
            Console.WriteLine("Enter the ID of the Team.(1,2,3,4)\n");
            int intAsstring = int.Parse(Console.ReadLine());
            DevTeam content = _Team.GetTeamById(intAsstring);
            

            if (content.TeamId == intAsstring)
            {
                Console.WriteLine($"Name:{content.Name}\n" +
                    $"Id:{content.TeamId}\n");
            }
            else
            {
                Console.WriteLine("Please enter a valid ID.");
            }
           
          
            
            // Find the developer
            Console.WriteLine("Enter the ID of developer that you want to add to that team.(1,2,3,4)\n");
           
            int intAsstring1 = int.Parse(Console.ReadLine());
            DeveloperInfo dev = _DevList.GetDeveloperById(intAsstring1);
            developer.Id = intAsstring1;
            if (dev.Id == intAsstring1)
            {
                Console.WriteLine($"Name:{dev.Name}\n" +
                    $"Id:{dev.Id}");
            }
            else
            {
                Console.WriteLine("Please enter a valid ID.");
            }
            
            
            // Add developer to Team
            content.Developer.Add(dev);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The developer was successfuly added to the list\n");
            Console.ResetColor();
            Console.WriteLine("Press any key to continue\n");
           

        }

        public void RemovedevelopersFromTeam()
        {
            DeveloperInfo developer = new DeveloperInfo();

            Console.WriteLine("Enter the ID of the Team.(1,2,3,4)\n");
            int intAsstring = int.Parse(Console.ReadLine());
            DevTeam content = _Team.GetTeamById(intAsstring);

            if (content.TeamId == intAsstring)
            {
                Console.WriteLine($"Name:{content.Name}\n" +
                    $"Id:{content.TeamId}\n");
            }
            else
            {
                Console.WriteLine("Please enter a valid ID");
               
            }
            
           
            // Find the developer
            Console.WriteLine("Enter the  ID of developer that you want to remove from that team.(1,2,3,4)\n");
            int intAsstring1 = int.Parse(Console.ReadLine());
            DeveloperInfo dev = _DevList.GetDeveloperById(intAsstring1);
            developer.Id = intAsstring1;
            if (dev.Id == intAsstring1)
            {
                Console.WriteLine($"Name:{dev.Name}\n" +
                    $"Id:{dev.Id}");
            }
            else
            {
                Console.WriteLine("Please enter a valid ID");
            }
            // Remove developer from Team
            content.Developer.Remove(dev);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The developer was successfuly removed from the list\n");
            Console.ResetColor();
            Console.WriteLine("Press any key to continue\n");
           // Console.ReadKey();
        }


        // See a list of existing developers
        private void DisplayListOfDevelopers()
        {


            Console.Clear();
            Console.WriteLine("List of Developers:\n");
            Console.ForegroundColor = ConsoleColor.Red;

            List<DeveloperInfo> listOfContent = _DevList.GetListOfDeveloper();
            foreach (DeveloperInfo content in listOfContent)
            {
                Console.WriteLine($"Name:{content.Name}\n" +
                    $"Id:{content.Id}\n");


            }
            Console.ResetColor();
            
        }


        // See a list of existing Teams
        private void DisplayListOfTeams()

        {
            Console.Clear();


            Console.WriteLine("List Of Teams:\n");

            Console.ForegroundColor = ConsoleColor.Blue;
            List<DevTeam> listOfContent = _Team.GetTeamlist();
            foreach (DevTeam content in listOfContent)
            {
                Console.WriteLine($"Name:{content.Name}\n" +
                    $"Id:{content.TeamId}\n");
                if (content.Developer == null) { }
                
                else
                {
                    foreach (DeveloperInfo dev in content.Developer)
                    {
                        Console.WriteLine($"Name:{dev.Name}\n");

                    }
                }
            }
            Console.ResetColor();
            Console.WriteLine("Press any key to continue\n");
            

        }

        // See whether or not the developers have access to the online learning tool: Pluralsight.

        public void HasAccessToPluralSight()
        {
            DeveloperInfo developer = new DeveloperInfo();
            Console.WriteLine("Enter the  ID of developer to see whether he/she has access to PluralSight.(1,2,3,4)");
            int intAsstring1 = int.Parse(Console.ReadLine());
            DeveloperInfo dev = _DevList.GetDeveloperById(intAsstring1);
            developer.Id = intAsstring1;
            if (dev.Id == intAsstring1)
            {
                Console.WriteLine($"Name:{dev.Name}\n" +
                    $"Id:{dev.Id}\n" +
                    $"Plural sight Access {dev.PluralSightAccess}");
           

                if (dev.PluralSightAccess == true)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{dev.Name} Has PluralSight Access\n");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{dev.Name} Has Not PluralSight Access\n");
                    Console.ResetColor();

                }
            }
            else
            {
                Console.WriteLine("No Content with This ID,Please Enter a Valid ID");
            }
            Console.WriteLine("Press any key to continue\n");
            


        }
        //Add multiple Developers to a team at once.

        public void AddMultipleDevelopersToTeam()
        {
       
            // Find Team
            Console.WriteLine("Enter the ID of the Team.");
            int intAsstring = int.Parse(Console.ReadLine());
            DevTeam content = _Team.GetTeamById(intAsstring);
            

            if (content.TeamId == intAsstring)
            {
                Console.WriteLine($"Name:{content.Name}\n" +
                    $"Id:{content.TeamId}\n");
            }
            else
            {
                Console.WriteLine("No content with this ID");
            }
           
          
            // Find the developers

            Console.WriteLine("Enter the IDs of  the 4 developers to add  them to the team(1,2,3,4. Press Enter after each ID#)");
            int[] answer = new int[5];
            
            for (int i =1; i < answer.Length; i++)
            {
                answer[i] = int.Parse(Console.ReadLine());
            }
            DeveloperInfo dev = _DevList.GetDeveloperById(answer[1]);
            DeveloperInfo dev1 = _DevList.GetDeveloperById(answer[2]);
            DeveloperInfo dev2 = _DevList.GetDeveloperById(answer[3]);
            DeveloperInfo dev3 = _DevList.GetDeveloperById(answer[4]);

            if (dev.Id == answer[1] && dev1.Id == answer[2] && dev2.Id == answer[3] && dev3.Id == answer[4])
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Name:{dev.Name}\n" +
                    $"Id:{dev.Id}"); 
                Console.WriteLine($"Name:{dev1.Name}\n" +
                    $"Id:{dev1.Id}");
                Console.WriteLine($"Name:{dev2.Name}\n" +
                   $"Id:{dev2.Id}");
                Console.WriteLine($"Name:{dev3.Name}\n" +
                   $"Id:{dev3.Id}");
                Console.ResetColor();

            }
            else
            {
                Console.WriteLine("No content with this ID");
            }
            // Add developers to Team
            content.Developer.Add(dev);
            content.Developer.Add(dev1);
            content.Developer.Add(dev2);
            content.Developer.Add(dev3);

             Console.WriteLine("Press any key to continue\n");

        }


        //See method

        public void SeedTeamList()
        {

           
           
            DevTeam Team1 = new DevTeam("Team1", 1, new List<DeveloperInfo> { });
            DevTeam Team2 = new DevTeam("Team2", 2, new List<DeveloperInfo> { });
            DevTeam Team3 = new DevTeam("Team3", 3, new List<DeveloperInfo> { });
            DevTeam Team4 = new DevTeam("Team4", 4, new List<DeveloperInfo> { });
            _Team.AddTeamToList(Team1);
            _Team.AddTeamToList(Team2);
            _Team.AddTeamToList(Team3);
            _Team.AddTeamToList(Team4);


        }

        //See method

        public void SeedDeveloperList()
        {
            DeveloperInfo MichaelPabody = new DeveloperInfo("Michael Pabody", 1, true);
            DeveloperInfo CaseyWilson = new DeveloperInfo("Casey Wilson", 2, false);
            DeveloperInfo MitchellReed = new DeveloperInfo("Mitchell Reed", 3, true);
            DeveloperInfo DrewGraber = new DeveloperInfo("Drew Graber", 4, false);
            _DevList.AddContentToList(MichaelPabody);
            _DevList.AddContentToList(CaseyWilson);
            _DevList.AddContentToList(MitchellReed);
            _DevList.AddContentToList(DrewGraber);


        }
    }
}
