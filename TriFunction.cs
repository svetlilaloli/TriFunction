using System;

namespace TriFunction
{
    class TriFunction
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split();
            //Func<string, int, bool> isEqualOrGrater = IsEqualOrGrater;
            Console.WriteLine(FirstEqualOrGrater(names, n, IsEqualOrGrater));
        }
        static string FirstEqualOrGrater(string[] names, int n, Func<string, int, bool> isEqualOrGrater)
        {
            foreach (string name in names)
            {
                if (isEqualOrGrater(name, n))
                {
                    return name;
                }
            }
            return null;
        } 
        static bool IsEqualOrGrater(string name, int n)
        {
            int sum = 0;
            foreach (char ch in name)
            {
                sum += ch;
            }
            if (sum >= n)
            {
                return true;
            }
            return false;
        }
    }
}
