using System;

namespace Open_Lab_03._5
{
    class Program
    {
        public static bool MatchCaseInsensitive(string a, string b)
        {
            return(a.ToLower() == b.ToLower());
        }

        static void Main(string[] args)
        {
            string name1 = Console.ReadLine();
            string name2 = Console.ReadLine();
            Console.WriteLine(MatchCaseInsensitive(name1, name2));

        }
    }
}
