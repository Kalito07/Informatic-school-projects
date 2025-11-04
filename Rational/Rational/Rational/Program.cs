using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rational
{
    internal class Pro
    { 
        public static void Main(string[] args)
        { 
            int xnum, xdenum, ynum, ydenum;
            xnum = int.Parse(Console.ReadLine());
            xdenum = int.Parse(Console.ReadLine());
            ynum = int.Parse(Console.ReadLine());
            ydenum = int.Parse(Console.ReadLine());
            Rational x = new Rational(xnum, xdenum);
            Rational y = new Rational(ynum, ydenum);

            Rational a= new Rational(x); a.Add(y); a.ToString();
            Rational s= new Rational(x); s.Sub(y); s.ToString();
            Rational m= new Rational(x); m.Mult(y); m.ToString();
            Rational d= new Rational(x); d.Div(y); d.ToString();
int c=x.Compare(y);
            if (c == 1)
            {
                Console.WriteLine("X>Y");
            }
            else if (c == -1)
            {
                Console.WriteLine("X<Y");
            }
            else
            {
                Console.WriteLine("X=Y");
            }
        }
    }

}
