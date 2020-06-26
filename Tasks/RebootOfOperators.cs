using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks
{
    namespace Operatorss
    {
        public class OperatorReboot
        {
            public OperatorReboot() { }
            public OperatorReboot(int size)
            {
                Size = size;
            }
            private int Size { get; set; }

            public override string ToString()
            {
                return "Size: " + Size.ToString();
            }
            public static OperatorReboot operator +(OperatorReboot c1, OperatorReboot c2)
            {
                return new OperatorReboot{ Size = c1.Size + c2.Size };
            }

            // < and > Перегружаются в связке!!!
            public static bool operator >(OperatorReboot c1, OperatorReboot c2)
            {
                return c1.Size > c2.Size;
            }

            public static bool operator <(OperatorReboot c1, OperatorReboot c2)
            {
                return c1.Size < c2.Size;
            }
            public static bool operator true(OperatorReboot c1)
            {
                return c1.Size != 0;
            }
            public static bool operator false(OperatorReboot c1)
            {
                return c1.Size == 0;
            }

            public static OperatorReboot operator ++(OperatorReboot c1)
            {
                return new OperatorReboot { Size = c1.Size + 1 };
            }
        }
    }
}
