using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcLibrary
{
    public static class Calc
    {
        /// <summary>
        /// Функція складання двох чисел
        /// </summary>
        /// <param name="a">доданок</param>
        /// <param name="b">доданок</param>
        /// <returns>сума</returns>
        public static double Add(double a, double b)
        {
            return a + b;
        }

        /// <summary>
        /// Функція знаходження частки
        /// </summary>
        /// <param name="a">ділене</param>
        /// <param name="b">дільник</param>
        /// <returns>частка</returns>
        public static double Div(double a, double b)
        {
            return a / b;
        }

        /// <summary>
        /// Функція множення двох чисел
        /// </summary>
        /// <param name="a">множник</param>
        /// <param name="b">множник</param>
        /// <returns>добуток</returns>
        public static double Mult(double a, double b)
        {
            return a * b;
        }

        /// <summary>
        /// Функція віднімання чисел a i b
        /// </summary>
        /// <param name="a">зменшуване</param>
        /// <param name="b">від'ємне</param>
        /// <returns>різниця</returns>
        public static double Sub(double a, double b)
        {
            return a - b;
        }

        /// <summary>
        /// Функція ділення по модулю
        /// </summary>
        /// <param name="a">Ділене</param>
        /// <param name="b">Дільник</param>
        /// <returns>Остача</returns>
        public static double Mod(double a, double b)
        {
            return a % b;
        }

        /// <summary>
        /// Унарний плюс
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static double ABS(double a)
        {
            return a;
        }

        /// <summary>
        /// Унарний мінус
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static double IABS(double a)
        {
            if (a < 0) return -a;

            if (a > 0) return -a;

            return 0;
        }
    }
}
