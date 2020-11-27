using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeamsProject
{
    public class DeveloperInfo
    {

        public enum GenreMonth
        {
            January=1,
            February,
            March,
            April,
            May,
            June,
            Jully,
            August,
            September,
            October,
            November,
            december

        }
        public string Name { get; set; }
        public int Id { get; set; }
        public string PluralSight { get; set; }

        public GenreMonth GenreOfMonth { get; set; }

        public DeveloperInfo(){}


        public DeveloperInfo(string name, int id, string Pluralsight, GenreMonth genreofmonth)
        {
            Name = name;
            Id = id;
            PluralSight= Pluralsight;
            GenreOfMonth = genreofmonth;


        }
    }
}
