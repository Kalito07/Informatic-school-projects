using System;

namespace Rational
{

    public class Rational
    {
        public int num { get; set; }
        public int denum { get; set; }

        public Rational(int num)
        {
            this.num = num;
            this.denum = 1;
        }

        public Rational(int num, int denum)
        {
            if (denum == 0)
            {
                throw new ArgumentException("Denominator cannot be 0");
            }
            this.num = num;
            this.denum = denum;
        }

        public Rational(Rational other)
        {
            this.num = other.num;
            this.denum = other.denum;
        }

        public void Add(Rational r)
        {
            this.num = this.num * r.denum + r.num * this.denum;
            this.denum = this.denum * r.denum;
            Simplify();
        }

        public void Sub(Rational r)
        {
            this.num = this.num * r.denum - r.num * this.denum;
            this.denum = this.denum * r.denum;
            Simplify();
        }

        public void Mult(Rational r)
        {
            this.num = this.num * r.num;
            this.denum = this.denum * r.denum;
            Simplify();
        }

        public void Div(Rational r)
        {
            if (r.num == 0)
            {
                throw new ArgumentException("Cannot divide by 0");
            }
            this.num = this.num * r.denum;
            this.denum = this.denum * r.num;
            Simplify();
        }

        public int Compare(Rational r)
        {
            int ls = this.num * r.denum;
            int rs = r.num * this.denum;

            if (ls > rs)
            {
                return 1;
            }
            else if (ls < rs)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        private void Simplify()
        {
            int g = NOD(Math.Abs(num), denum);
            this.num /= g;
            this.denum /= g;
        }

        private int NOD(int a, int b)
        {
            return b == 0 ? a : NOD(b, a % b);
        }

        public double GetDecimal()
        {
            Simplify();
            return (double)this.num / this.denum;
        }

        public override string ToString()
        {
            return $"{num}/{denum} = {GetDecimal()}";
        }
    }

}
