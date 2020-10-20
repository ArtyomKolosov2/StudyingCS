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
                IOService.ShowUserStringWithLineBreak("z == null");
            }
            z = 50;
            if (z.HasValue && Flag.Value)
            {
                IOService.ShowUserStringWithLineBreak($"z = {z.Value}, Flag = true");
            }
            IOService.ShowUserStringWithLineBreak(color.GetValueOrDefault(Color.Red));
        }
    }
}
