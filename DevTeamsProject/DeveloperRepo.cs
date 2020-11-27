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

        //Developer Create

        public void AddDeveloperToTeam(DeveloperInfo listofdevelopers)
        {
            _developerDirectory.Add(listofdevelopers);
        }
        //Developer Read

        public List<DeveloperInfo> GetListOfDeveloper()
        {
            return _developerDirectory;
        }
        //Developer Update

        public bool UpdateDeveloperList( string originalName,DeveloperInfo newList)


        {    //Find the list

            DeveloperInfo oldList = GetDeveloperById(originalName);
            
            //Update the list
            if( oldList != null)
            {
                oldList.Name = newList.Name;
                oldList.Id = newList.Id;
                oldList.PluralSight = newList.PluralSight;
                oldList.GenreOfMonth = newList.GenreOfMonth;
                return true;
            }
            else
            {
                return false;
            }

        } 



        //Developer Delete

        public bool RemoveDevloperFromList(string name)
        {
            //Find the list
            DeveloperInfo list = GetDeveloperById(name);
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

        public DeveloperInfo GetDeveloperById(string name)
        {
            foreach(DeveloperInfo list in _developerDirectory)
            {
                if (list.Name== name)
                {
                    return list;
                }
                
            }
            return null;

        }
    }
}
