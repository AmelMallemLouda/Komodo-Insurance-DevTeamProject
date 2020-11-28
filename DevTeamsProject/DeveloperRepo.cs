using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeamsProject
{
    public class DeveloperRepo
    {
        private readonly List<DeveloperInfo> _developerDirectory = new List<DeveloperInfo>();
        private readonly List<DevTeam> dev = new List<DevTeam>();
        public DevTeamRepo _Team = new DevTeamRepo();
        public void AddContentToList(DeveloperInfo content)
        {
            _developerDirectory.Add(content);
        }
        //Developer Create
        
        public void AddDevelopersToTeams(DevTeam team,DeveloperInfo developer )

        {
            // Find the developer
            Console.WriteLine("enter the ID of the developer that you want to add");
            string input = Console.ReadLine();
           


             





        }
        //Developer Read

        public List<DeveloperInfo> GetListOfDeveloper()
        {
            return _developerDirectory;
        }
        //Developer Update

        public bool UpdateDeveloperList( int id,DeveloperInfo newList)


        {    //Find the list

            DeveloperInfo oldList = GetDeveloperById(id);
            
            //Update the list
            if( oldList != null)
            {
                oldList.Name = newList.Name;
                oldList.Id = newList.Id;
                oldList.PluralSight = newList.PluralSight;
                
                return true;
            }
            else
            {
                return false;
            }

        } 



        //Developer Delete

        public bool RemoveDevloperFromList(int id)
        {
            //Find the list
            DeveloperInfo list = GetDeveloperById(id);
            if (list == null)
            {
                return false;
            }
            //Remove from list

            int initialList = _developerDirectory.Count;
            _developerDirectory.Remove(list);
            if (initialList > _developerDirectory.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
            





        //Developer Helper (Get Developer by ID)

        public DeveloperInfo GetDeveloperById(int id)
        {
            foreach(DeveloperInfo list in _developerDirectory)
            {
                if (list.Id == id)
                {
                    return list;
                }
                
            }
            return null;

        }
    }
}
