using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeamsProject
{
    public class DeveloperInfo
    {

       
        public string Name { get; set; }
        public int Id { get; set; }
        public string PluralSight { get; set; }
       

        public DeveloperInfo(){}


        public DeveloperInfo(string name, int id, string Pluralsight)
        {
            Name = name;
            Id = id;
            PluralSight= Pluralsight;
           


        }
    }
}
