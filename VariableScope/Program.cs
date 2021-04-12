using System;

namespace VariableScope
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = 10;

            //BlockScope();
            FunctionScope(y);
            Console.WriteLine(y);
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

        private static void FunctionScope(int y)
        {
            //this is a function scope variable
            int x = 20;
            Console.WriteLine("x="+x);

            Console.WriteLine("y="+y);
            y = 20;
            Console.WriteLine(y);

            if (true)
            {
                //z is a block scope variable
                int z = 30;
                Console.WriteLine(z);

                if (true)
                {
                    Console.WriteLine(x);
                    Console.WriteLine(y);
                }
            }
            Console.WriteLine(x);
            Console.WriteLine(y);

            
        }
    }
}
