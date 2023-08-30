using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcept
{
    public class Demo3Loops
    {
        public static void Main3(string[] args)
        {
            int[] numbers = { 10, 50, 68, 7, 25, 65, 45, 41, 56 };

            for (int i = 0; i<numbers.Length-1; i++)
            {
                {
                    if ( numbers[i]<=50)
                        {
                Console.WriteLine(numbers[i]);
                        }
                }
     
            }
            string[] fruits = { "mango", "orange", "apple", "jackfruit" };
            foreach(string str in fruits)
            {
                if(str.Equals("orange"))
                {
                    continue;
                }
                Console.WriteLine(str);
                
              
            }
        }
        


        
    }
}
