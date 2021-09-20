using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Tasks
namespace Collections
{
    class Assignment
    {
        static void Main(String[] args)
        {
            List<string> empname = new List<string>();
            empname.Add("Vineeth");
            for each(var name in empname)
            {
                Console.WriteLine(name);
            }
            List<string> distinct=empname.distinct.ToList();
            {
                foreach(var a in distinct)
                {
                    Console.WriteLine(a);
                }
                Console.Readkey();
            }
        }
    }
}