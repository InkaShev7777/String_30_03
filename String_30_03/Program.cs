using System;

namespace String_30_03
{
    class Program
    {
        static void Main(string[] args)
        {
            // замена всех слов короче 3 символов на secret


            //string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
            //string[] mas = text.Split(" ");
            //for (int i = 0; i < mas.Length; i++)
            //{
            //    if (mas[i].Length < 3)
            //    {
            //        mas[i] = "SECRET";
            //    }
            //    Console.Write($"{mas[i]} ");
            //}


            //вывод слов по убыванию


            string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
            string[] mas = text.Split(" ");
            string zam;
            for(int i = 0;i<mas.Length;i++)
            {
                for(int j = mas.Length-1;j>i;j--)
                {
                    if (mas[j].Length > mas[j - 1].Length)
                    {
                        zam = mas[j];
                        mas[j] = mas[j - 1];
                        mas[j - 1] = zam;
                    }
                }
                
            }
            for (int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine($"{mas[i]} ");
            }
                Console.ReadKey();
        }
    }
}
