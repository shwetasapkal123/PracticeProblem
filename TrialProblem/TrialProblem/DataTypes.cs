using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrialProblem
{
    internal class DataTypes
    {
        public static void operatorOperation()
        {
            //Implicit Castig is done smaller to larger size type
            // char->int->long->float->double
            int myInt = 9;
            double myDouble = myInt;
            double myFloat = myDouble;
            Console.WriteLine("Implicit Casting :" + myDouble + " " + myFloat);
            //Explicit Casting is done manually from larger to smaller by placing type in paranthesis
            //double->float->long->int->char
            double myDouble2 = 9.78;
            int myInt2 = (int)myDouble2;
            bool myBool = true;
            Console.WriteLine("explicit type is " + myInt2);
            Console.WriteLine(Convert.ToString(myInt));
            Console.WriteLine(Convert.ToDouble(myInt2));
            Console.WriteLine(Convert.ToString(myBool));
        }
    }
}
