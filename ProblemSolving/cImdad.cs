using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    public static class cImdad
    {
        public static void useZigZag(int[] arr = null)
        {
            int[] test1 = { 4, 3, 7, 8, 6, 2, 1 };
            if (arr != null)
                test1 = arr;

            ZigZag(test1);
        }


        private static void ZigZag(int[] arr)
        {
            bool flag = true; // this flag is swap the condition greater and less than.

            for (int i = 0; i < arr.Length - 2; i++)
            {
                if (flag)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                    }
                }
                else
                {
                    if (arr[i] < arr[i + 1])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                    }
                }
                flag = !flag;
            }
            foreach (int a in arr)
            {
                Console.Write(a.ToString() + " ");
            }
            Console.ReadLine();
        }
        public static void useSuperReducedString(string str = "")
        {
            string test1 = "aaabccddd";
            if (str.Length > 0)
                test1 = str;

            Console.WriteLine(superReducedString(test1));
        }
        private static string superReducedString(string s)
        {
            if (s == "") return "Empty String";
            if (s.Length >= 2)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (s.Length > (i + 1))
                    {
                        string str1 = s[i].ToString();
                        string str2 = s[i + 1].ToString();
                        if (str1 == str2)
                        {
                            string str = s.Remove(i, 2);
                            return superReducedString(s.Remove(i, 2));
                        }
                    }
                }
            }
            return s;
        }
    }
}
