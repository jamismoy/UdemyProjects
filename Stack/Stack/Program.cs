using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            
            for (int i = 0; i <= 10; i++)
            {
                stack.Push(i);
            }

            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine(stack.Pop());
            }

        }
    }
}
