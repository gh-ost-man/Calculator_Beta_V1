using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Error8
{
    class Program
    {
        static void Main(string[] args)
        {

            string str = Console.ReadLine();

            int znak = 0;
            int num_count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].ToString() != " ")// If string is not empty we go forward ->
                {
                    if (str[i].ToString().Contains("+") || str[i].ToString().Contains("-") || str[i].ToString().Contains("/") || str[i].ToString().Contains("*"))// Check on symbols in string
                    {
                        znak++;
                    }
                    else// If string != " " and != symb than we can calculate it`s like a number
                    {
                        num_count++;
                    }
                }
            }

            int res = znak + num_count;
            Console.WriteLine($"Nums: {num_count}");
            Console.WriteLine($"Symbols: {znak}");
            Console.WriteLine($"All: {res}");

            if (res > 30)
            {
                Console.WriteLine("Error 8! Nums more than 30!");
            }


        }
    }
}
