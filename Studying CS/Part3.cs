using System;
using System.Collections.Generic;
using System.Text;
using TasksPartThree.StudyExtinsions;
using TasksPartThree.StudyPartial;

namespace Studying_CS
{
    public static class Part3
    {
        public static void PartThreeStart()
        {
            int amount = 50;
            string splitter = "=";
            Program.center(amount, "Start of The Third Part", "*");
            //////////////////////////////////////////////
            Program.center(amount, "Extinsions", splitter);
            Extinsions extinsions = new Extinsions();
            extinsions.StartExample();
            //////////////////////////////////////////////
            Program.center(amount, "Partial methods and classes", splitter);
            StartPartial.StartExample();
            //////////////////////////////////////////////
        }
    }
}
