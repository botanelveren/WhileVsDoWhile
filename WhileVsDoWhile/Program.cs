using System;

namespace WhileVsDoWhile
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir limit değeri giriniz.");
            int limit = Convert.ToInt32(Console.ReadLine());

            int i = 0;
            while (i <= limit)
            {
                Console.WriteLine("Ben bir Patika'lıyım.");
                i++;
            }
            //The difference between while and do-while is that in do-while the "do" scope works at least once before condition is checked.
            i = 0;
            do
            {
                Console.WriteLine("Ben bir Patika'lıyım.");
                i++;
            } while (i <= limit);


        }
    }
}