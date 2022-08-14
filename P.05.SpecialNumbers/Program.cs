using System;

namespace P._05.SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            

            for (int i = 1111; i <= 9999; i++)
            {
                bool flag = true;
                string number = i.ToString();
                for (int j = 0; j < number.Length; j++)
                {
                    int currentNum = int.Parse(number[j].ToString());
                    if (currentNum == 0)
                    {
                        flag = false;
                        break;
                    }
                    if (n % currentNum != 0)
                    {
                        flag = false;
                    }
                }
                if (flag)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
