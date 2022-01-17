using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrialProblem
{
    internal class MathAndString
    {
        public static void defineMathStrlength()
        {
            int x, y;
            double z;
            Console.WriteLine("Enter first Number");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter decimal Number which you want to find round figure");
            z= Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Maximum Number is:" + Math.Max(x, y));
            Console.WriteLine("Minimum number is:"+ Math.Min(x,y));
            Console.WriteLine("Square root of first number is:" + Math.Sqrt(x));
            Console.WriteLine("Absoulte positive second number is: "+ Math.Abs(y));
            Console.WriteLine("whole nuber is:"+Math.Round(z));

            string txt = "Hello I am Shweta Suresh Sapkal";
            Console.WriteLine("The length of txt is:"+ txt.Length);
            Console.WriteLine(txt.ToUpper());
            Console.WriteLine(txt.ToLower());
            string firstname = "I am ";
            string secondname = "From Maharashtra";
            string name=string.Concat(firstname,secondname);
            Console.WriteLine(name);
            string inter = $"I have Completed my Engineering in 2018";
            Console.WriteLine("By Using Interpolation:" + inter);
            Console.WriteLine("print first array charactor position:" + txt[1]);
            Console.WriteLine("Position of S in txt is " + txt.IndexOf("S"));
            string lastname=name.Substring(name.IndexOf("S")+1);
            Console.WriteLine("By Using Substring"+lastname);
        }

    }
}
