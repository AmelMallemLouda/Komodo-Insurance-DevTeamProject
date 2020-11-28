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

        public List<DeveloperInfo> Developer { get; set; }



        public DevTeam() { }
        public DevTeam(string name,int teamnumber, List<DeveloperInfo> developer)
        {
            TeamId = teamnumber;
           
            Name = name;

            Developer = developer;
            

        }
    }
}