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
        public DeveloperRepo _DevList = new DeveloperRepo();
        public DevTeamRepo _Team = new DevTeamRepo();
        public DevTeam devTeam = new DevTeam();
        
        public DeveloperInfo developer = new DeveloperInfo();
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
                    "5.Get a list of all the Developers that need a Pluralsight license monthly.\n" +
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
                        AddDevelopers(developer);


                        break;
                    case "4":
                        AddDevelopersToTeams(developer);
                        break;
                    case "5":
                        break;
                    case "6":
                        break;
                    case "7":
                        break;
                    case "8":
                        Console.WriteLine("GoodBye");
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
            Console.WriteLine("Enter the name of the new Team.");
            newTeam.Name = Console.ReadLine();

            //TeamID

            Console.WriteLine("Enter the ID of the new Team.");
           string input = Console.ReadLine();
           

            _Team.AddTeamToList(newTeam);

        }

        //Add developpers individually from the developer directory to that team
        public void AddDevelopersToTeams(DeveloperInfo developer)

        {
            List<DeveloperInfo> newList = new List<DeveloperInfo>();
            // Find the developer
            Console.WriteLine("Enter the ID of the developer that you want to add");
            int intAsstring = int.Parse(Console.ReadLine());
            developer.Id = intAsstring;

            Console.WriteLine("Enter the Name of the developer that you want to add");
            string name = Console.ReadLine();
            developer.Name = name;
            Console.Clear();
            newList.Add(developer);

            devTeam.Developer = newList;



        }
        // Find the  the New Team

        public void AddDevelopers(DeveloperInfo developer)

        {
            // Find the developer
            Console.WriteLine("Enter the ID of the developer that you want to add");
             string input = Console.ReadLine();
            Console.Clear();
           

            _Team.AddDevelopersToTeams(developer);

            Console.WriteLine("Enter the ID of the team to add the developer to it");
            string input1 = Console.ReadLine();
            
            switch (input1)
            {
                case "1":
                    Console.WriteLine("Add the developer to team 1" );
                   


                    break;
                case "2":
                    Console.WriteLine("Add the developer to team 2");
                    break;
            }





        }

            // See a list of existing developers

            private void DisplayListOfDevelopers()
        {
            // Prompt the user to give me the ID of the Team

            Console.Clear();
            Console.WriteLine("List of developer\n");

            List<DeveloperInfo> listOfContent = _DevList.GetListOfDeveloper();
            foreach (DeveloperInfo content in listOfContent)
            {
                Console.WriteLine($"Name:{content.Name}\n" +
                    $"Id:{content.Id}\n");
            }
        }
        private void DisplayListOfTeams()
        {
            // Prompt the user to give me the ID of the Team
            Console.WriteLine("List of teams\n");


            List<DevTeam> listOfContent = _Team.GetTeamlist();
            foreach (DevTeam content in listOfContent)
            {
                Console.WriteLine($"Name:{content.Name}\n" +
                    $"Id:{content.TeamId}\n" +
                    $"developer:{content.Developer}");
            }
        }


        //See method

        private void SeedTeamList()
        {
            DeveloperInfo MichaelPabody = new DeveloperInfo("Michael Pabody",1, "adasd");
            DeveloperInfo CaseyWilson = new DeveloperInfo("Casey Wilson", 1, "asdsd");
            DeveloperInfo MitchellReed = new DeveloperInfo("Mitchell Reed", 3, "sdasd");
            DeveloperInfo DrewGraber = new DeveloperInfo("Drew Graber", 4, "assd");
            List<DeveloperInfo> newList = new List<DeveloperInfo>();
            newList.Add(MichaelPabody);
            newList.Add(DrewGraber);
            DevTeam Team1 = new DevTeam("Team1", 1,new List<DeveloperInfo> {MichaelPabody,CaseyWilson});
            DevTeam Team2 = new DevTeam("Team2", 2, new List<DeveloperInfo> { MichaelPabody, CaseyWilson });
            DevTeam Team3 = new DevTeam("Team3", 3, new List<DeveloperInfo> { MichaelPabody, CaseyWilson }) ;
            DevTeam Team4 = new DevTeam("Team4",4, new List<DeveloperInfo> { MichaelPabody, CaseyWilson });
            _Team.AddTeamToList(Team1);
            _Team.AddTeamToList(Team2);
            _Team.AddTeamToList(Team3);
            _Team.AddTeamToList(Team4);

        }

        //See method

        private void SeedDeveloperList()
        {
            DeveloperInfo MichaelPabody = new DeveloperInfo("Michael Pabody", 1, "adasd");
            DeveloperInfo CaseyWilson = new DeveloperInfo("Casey Wilson", 2, "asdsd");
            DeveloperInfo MitchellReed = new DeveloperInfo("Mitchell Reed",3, "sdasd");
            DeveloperInfo DrewGraber = new DeveloperInfo("Drew Graber", 4, "assd");
            _DevList.AddContentToList(MichaelPabody);
            _DevList.AddContentToList(CaseyWilson);
            _DevList.AddContentToList(MitchellReed);
            _DevList.AddContentToList(DrewGraber);

           ;


        }
    }
}
