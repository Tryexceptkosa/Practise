using System;
using System.Collections;

namespace KostenkoAnton_Task4_3009
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input string for stack : ");
            string userinput = Console.ReadLine();
            Stack st = new Stack();
            for (int i = 0; i < userinput.Length - 1; i++)
            {
                if (userinput[i] == '+')
                {
                    st.Push(userinput[i + 1]);
                }
                else if (userinput[i] == '-')
                {
                    Console.WriteLine(st.Peek());
                    st.Pop();
                }
            }
            Console.ReadKey();
        }
    }
}
