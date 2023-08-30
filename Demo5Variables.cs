using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcept
{
    public class Demo5Variables
    {
        public static int A1=10;

        public int A2=10;

        public static void Main11(string[] args)
        {
            Console.WriteLine(A1);

            Demo5Variables obj=new Demo5Variables();
            Console.WriteLine(obj);
        }
    }
}
