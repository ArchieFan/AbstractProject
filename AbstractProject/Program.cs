using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AbsChild c = new AbsChild();
            c.Add(150, 45);
            c.Sub(100, 80);
            c.Mul(5, 5);
            c.Div(5, 5);

            AbsParent p = c;
            p.Add(150, 45);
            p.Sub(100, 80);
            p.Mul(5, 5);
            p.Div(5, 5);
            Console.ReadLine();
        }
    }
}
