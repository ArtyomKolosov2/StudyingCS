using System;
using System.Collections.Generic;
using System.Text;

namespace TasksPartThree
{
    public static class PatternMatching
    {
        public static void StartExample()
        {
            One first = new Two() { IsLegit=true};
            Two second = new Two();
            Two third = null;
            if (first is Two two1) // If pattern mathing
            {

            }
            switch (first)
            {
                case Two two when two.IsLegit:
                    break;
                case null:
                    break;
                default:
                    Console.WriteLine("NoPattern");
                    break;

            }
        }
    }
    class One
    {

    }
    class Two : One
    {
        public bool IsLegit { get; set; } = false;
    }
}
