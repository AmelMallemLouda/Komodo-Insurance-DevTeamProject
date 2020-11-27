using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeamsProject
{

   
    public class DevTeam

    {
        public string Name { get; set; }
        public int TeamId { get; set; }
        public string DevelopersOfTeam { get; set; }



        public DevTeam() { }
        public DevTeam(string name,int teamnumber,  string developersofteam)
        {
            TeamId = teamnumber;
            DevelopersOfTeam = developersofteam;
            Name = name;

        }
    }
}