using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace TasksPartThree.NullableTypes
{
    public static class NullableTypes
    {
        public static void StartExample()
        {
            int? z = null;
            Color? color = null;
            Nullable<bool> Flag = true;
            if (z == null)
            {
                Console.WriteLine("z == null");
            }
            z = 50;
            if (z.HasValue && Flag.Value)
            {
                Console.WriteLine($"z = {z.Value}, Flag = true");
            }
            Console.WriteLine(color.GetValueOrDefault(Color.Red));
        }
    }
}
