using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigInt
{
    public class BigInt
    {
        public string value;
        public char sign;

        public BigInt()
        {
            this.sign = '+';
            this.value = "";
        }

        public BigInt(string s)
        {
            if (s[0] == '+' || s[0] == '-')
            {
                this.sign = s[0];
                this.value = s.Substring(1);
            }
            else
            {
                this.sign = '+';
                this.value = s;
            }
        }

        public void Print()
        {
            if (this.sign == '-')
                Console.Write(this.sign);

            int i = 0;
            while (i < this.value.Length - 1 && this.value[i] == '0')
                i++;

            Console.WriteLine(this.value.Substring(i));
        }

        private char AddDigit(char d1, char d2, ref int p)
        {
            int x = (d1 - '0') + (d2 - '0') + p;
            p = x / 10;
            return (char)(x % 10 + '0');
        }

        public BigInt AddPos(BigInt b)
        {
            int i = this.value.Length - 1;
            int j = b.value.Length - 1;
            int p = 0;
            string resultValue = "";

            while (i >= 0 || j >= 0)
            {
                char d1 = i >= 0 ? this.value[i] : '0';
                char d2 = j >= 0 ? b.value[j] : '0';
                char sumDigit = AddDigit(d1, d2, ref p);
                resultValue = sumDigit + resultValue;
                i--;
                j--;
            }

            if (p > 0)
                resultValue = (char)(p + '0') + resultValue;

            return new BigInt("+" + resultValue);
        }

        public int ComparePos(BigInt b)
        {
            if (this.value.Length > b.value.Length) return 1;
            if (this.value.Length < b.value.Length) return -1;

            for (int i = 0; i < this.value.Length; i++)
            {
                if (this.value[i] > b.value[i]) return 1;
                if (this.value[i] < b.value[i]) return -1;
            }

            return 0;
        }

        public BigInt SubPos(BigInt b)
        {
            int aLen = this.value.Length;
            int bLen = b.value.Length;

            char[] a = this.value.ToCharArray();
            char[] sub = new char[aLen];
            for (int m = 0; m < sub.Length; m++)
            {
                sub[m] = '0';
            }

            int i = aLen - 1;
            int j = bLen - 1;

            while (j >= 0)
            {
                if (a[i] >= b.value[j])
                {
                    sub[i] = (char)(a[i] - b.value[j] + '0');
                }
                else
                {
                    int k = i - 1;
                    while (a[k] == '0')
                    {
                        a[k] = '9';
                        k--;
                    }
                    a[k]--;
                    sub[i] = (char)(a[i] + 10 - b.value[j] + '0');
                }
                i--; j--;
            }

            while (i >= 0)
            {
                sub[i] = a[i];
                i--;
            }

            string resultValue = new string(sub).TrimStart('0');
            if (resultValue == "") resultValue = "0";
            return new BigInt("+" + resultValue);
        }
        public static BigInt operator +(BigInt a, BigInt b)
        {
            return a.Add(b);
        }

        public BigInt Add(BigInt b)
        {
            BigInt result;

            if (this.sign == b.sign)
            {
                result = this.AddPos(b);
                result.sign = this.sign;
            }
            else
            {
                int cmp = this.ComparePos(b);
                if (cmp == 0)
                {
                    result = new BigInt("+0");
                }
                else if (cmp > 0)
                {
                    result = this.SubPos(b);
                    result.sign = this.sign;
                }
                else
                {
                    result = b.SubPos(this);
                    result.sign = b.sign;
                }
            }

            return result;
        }
        public static BigInt operator -(BigInt a, BigInt b)
        {
            return a.Sub(b);
        }
        public static BigInt operator *(BigInt a, BigInt b)
        {
            return a.Mul(b);
        }

        public BigInt Sub(BigInt b)
        {
            BigInt negB = new BigInt((b.sign == '+') ? "-" + b.value : "+" + b.value);
            return this.Add(negB);
        }

        public BigInt MulDig(char c)
        {
            int d = c - '0';
            int carry = 0;
            string resultValue = "";

            for (int i = this.value.Length - 1; i >= 0; i--)
            {
                int x = (this.value[i] - '0') * d + carry;
                carry = x / 10;
                resultValue = (char)(x % 10 + '0') + resultValue;
            }

            if (carry > 0)
                resultValue = carry.ToString() + resultValue;

            return new BigInt("+" + resultValue);
        }
        public static bool operator ==(BigInt a, BigInt b)
        {
            return a.sign == b.sign && a.value == b.value;
        }

        public static bool operator !=(BigInt a, BigInt b)
        {
            return !(a == b);
        }
        public override bool Equals(object obj)
        {
            if (obj is BigInt other)
            {
                return this == other;
            }
            return false;
        }


        public BigInt MulPos(BigInt b)
        {
            BigInt result = new BigInt("0");
            string zeros = "";

            for (int i = b.value.Length - 1; i >= 0; i--)
            {
                BigInt temp = this.MulDig(b.value[i]);
                temp.value += zeros;
                result = result.Add(temp);
                zeros += "0";
            }

            return result;
        }

        public BigInt Mul(BigInt b)
        {
            BigInt result = this.MulPos(b);

            if (this.value == "0" || b.value == "0")
                result.sign = '+';
            else if (this.sign == b.sign)
                result.sign = '+';
            else
                result.sign = '-';

            return result;
        }
    }
}

internal class Program
    {
        static void Main(string[] args)
        {

        }
}

