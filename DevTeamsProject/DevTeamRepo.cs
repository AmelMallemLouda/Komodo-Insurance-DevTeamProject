using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeamsProject
{
    public class DevTeamRepo
    {

        public  List<DevTeam> _devTeams = new List<DevTeam>();
        public DevTeam devTeam = new DevTeam();

        //DevTeam Create
        public void AddTeamToList(DevTeam listofteams)
        {
            _devTeams.Add(listofteams);
        }

        //DevTeam Read

        public List<DevTeam> GetTeamlist()
        {
            return _devTeams;
        }

        //DevTeam Update

        public bool UpdateExistingList(int originalId,DevTeam newlist)
        {
         //Find a list

          DevTeam oldList = GetTeamById(originalId);

            //Update the  list

            if (oldList != null)
            {
                oldList.TeamId = newlist.TeamId;
               
                return true;
            }
            else
            {
                return false;
            }


        }
        //DevTeam Delete


        public bool RemoveExistingList(int id)
        {
            //find a list

            DevTeam list = GetTeamById(id);
            if (list == null)
            {
                return false;
            }
            int initialCount = _devTeams.Count;
            _devTeams.Remove(list);
            if (initialCount > _devTeams.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //DevTeam Helper (Get Team by ID)

        public DevTeam GetTeamById(int id)

        {
            foreach (DevTeam team in _devTeams)
            {
                if (team.TeamId== id)
                {
                    return team;
                }
            }
            return null;
        }

    }
}
