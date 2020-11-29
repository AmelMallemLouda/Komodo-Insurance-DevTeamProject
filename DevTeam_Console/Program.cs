﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeam_Console
{
     public class Program
    {
        static void Main(string[] args)
        {
            ProgramUI program = new ProgramUI();
            program.Run();
            program.SeedTeamList();
            program.SeedDeveloperList();
        }
    }
}
