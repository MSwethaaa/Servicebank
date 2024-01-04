using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace TestApp
{
    static class TestExt
    {
        public static void ExtTapCard(this TestApp t)
        {
            Console.WriteLine("this is extention method");
        }
    }
    internal class TestApp
    {
        static void Main(string[] args)
        {
            // Existing features
            College college = new College();
            college.Tenth();
            college.plus2();
            college.Graduation();
            college.postgradution()

           
        }
    }
}

