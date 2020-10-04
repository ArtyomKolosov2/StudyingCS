using Studying_CS.IOservices;
using System;
using System.Drawing;

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
                ConsoleIOService.ShowUserStringWithLineBreak("z == null");
            }
            z = 50;
            if (z.HasValue && Flag.Value)
            {
                ConsoleIOService.ShowUserStringWithLineBreak($"z = {z.Value}, Flag = true");
            }
            ConsoleIOService.ShowUserStringWithLineBreak(color.GetValueOrDefault(Color.Red));
        }
    }
}
