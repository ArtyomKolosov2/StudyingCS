using TasksPartThree.LocalFunctionsStudy;
using TasksPartThree.NullableTypes;
using TasksPartThree.ReferenceVars;
using TasksPartThree.StudyAnonymous;
using TasksPartThree.StudyDeconstruction;
using TasksPartThree.StudyExtinsions;
using TasksPartThree.StudyPartial;
using TasksPartThree.StudyPatternMacthing;

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
            Program.center(amount, "Anon types", splitter);
            AnonoimoysTypes.StartExample();
            //////////////////////////////////////////////
            Program.center(amount, "Local functions", splitter);
            LocalFunctions.StartExample();
            //////////////////////////////////////////////
            Program.center(amount, "Deconstruction for beginers", splitter);
            Deconstruction.StartExample();
            //////////////////////////////////////////////
            Program.center(amount, "Pattern matching", splitter);
            PatternMatching.StartExample();////
            //////////////////////////////////////////////
            Program.center(amount, "Nullable Types", splitter);
            NullableTypes.StartExample();
            //////////////////////////////////////////////
            Program.center(amount, "Reference vars", splitter);
            ReferenceVars.StartExample();
            //////////////////////////////////////////////
        }
    }
}
