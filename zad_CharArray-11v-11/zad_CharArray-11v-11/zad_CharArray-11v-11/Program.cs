using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace zad_CharArray_11v_11
{
    public class CharArray
    {
        private char[] index;
        public int Length { get; private set; }

        public CharArray()
        {
            index = new char[64];
            Length = 0;
        }

        public CharArray(int n)
        {
            index = new char[n];
            Length = 0;
        }

        public CharArray(string s)
        {
            index = new char[s.Length];
            Length = s.Length;
            for (int i = 0; i < s.Length; i++)
            {
                index[i] = s[i];
            }
        }

        public override string ToString()
        {
            return new string(index, 0, Length);
        }

        public void Delete(int pos)
        {
            if (pos < 0 || pos >= Length)
                throw new Exception("Error");

            for (int i = pos; i < Length - 1; i++)
            {
                index[i] = index[i + 1];
            }
            Length--;
        }

        public void Insert(int pos, char item)
        {
            if (pos < 0 || pos > Length || Length >= index.Length)
                throw new Exception("Error");

            for (int i = Length; i > pos; i--)
            {
                index[i] = index[i - 1];
            }

            index[pos] = item;
            Length++;
        }

        public void Replace(int pos, char item)
        {
            if (pos < 0 || pos >= Length)
                throw new Exception("Error");

            index[pos] = item;
        }

        public CharArray Substring(int start, int length)
        {
            if (start < 0 || start >= Length || length < 0 || start + length > Length)
                throw new Exception("Error");

            CharArray sub = new CharArray(length);
            for (int i = 0; i < length; i++)
            {
                sub.index[i] = index[start + i];
            }
            sub.Length = length;
            return sub;
        }

        public int IndexOf(CharArray pattern)
        {
            if (pattern.Length > Length)
                return -1;

            for (int i = 0; i <= Length - pattern.Length; i++)
            {
                int j;
                for (j = 0; j < pattern.Length; j++)
                {
                    if (index[i + j] != pattern.index[j])
                        break;
                }
                if (j == pattern.Length)
                    return i;
            }
            return -1;
        }

        public static CharArray Merge(CharArray a, CharArray b)
        {
            CharArray merged = new CharArray(a.Length + b.Length);
            for (int i = 0; i < a.Length; i++)
            {
                merged.index[i] = a.index[i];
            }
            for (int i = 0; i < b.Length; i++)
            {
                merged.index[a.Length + i] = b.index[i];
            }
            merged.Length = a.Length + b.Length;
            return merged;
        }

        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            CharArray s = new CharArray(input);
        }
    }
}
