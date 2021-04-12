using System;

namespace VariableScope
{
    class Program
    {
        static void Main(string[] args)
        {
            BlockScope();
        }
        private static void BlockScope()
        {
            {
                //here is a block scope parent
                int i = 10;
                i = i + 30;
                Console.WriteLine(i);
                {
                    //here is a child block scope

                    //not allowed
                    //int i=5;

                    //we can reuse variables defined in the parent block scope
                    i = i * 5;
                    Console.WriteLine(i);
                }
            }

            //there are specific C# works that open block scopes
            //e.g.: if, for,///
            if (true)
            {
               // .....
            }

            Console.WriteLine("-----------------------------------");

            for (int k=0;k<3;k++)
            {
                Console.WriteLine(k);
            }
        } 
    }
}
