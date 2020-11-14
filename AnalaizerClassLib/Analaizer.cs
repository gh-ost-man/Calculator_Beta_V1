using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace AnalaizerClassLib
{
    public static class Analaizer
    {
        static List<string> errors = new List<string>
             {
                "Неправильна структура в дужках",
                "Невiдомий оператор",
                "Невiрна синтаксична конструкцiя вхiдного виразу.",
                "Два пiдряд оператори",
                "Незавершений вираз.",
                "Дуже мале, або дуже велике значення числа для int. Числа повиннi бути в межах вiд -2147483648 до 2147483647.",
                "Дуже довгий вираз. Максмальная довжина — 65536 символiв.",
                "Сумарна кiлькiсть чисел i операторiв перевищує 30.",
                "Помилка дiлення на 0."
             };

        //Метод возвращает true, если проверяемый символ - разделитель ("пробел" или "равно")
        static private bool IsDelimeter(char c)
        {
            if ((" =".IndexOf(c) != -1))
                return true;
            return false;
        }
        //Метод возвращает true, если проверяемый символ - оператор
        static private bool IsOperator(char с)
        {
            if (("+-/*^()".IndexOf(с) != -1))
                return true;
            return false;
        }

        //Метод возвращает приоритет оператора
        static private byte GetPriority(char s)
        {
            switch (s)
            {
                case '(': return 0;
                case ')': return 1;
                case '+': return 2;
                case '-': return 3;
                case '*': return 4;
                case '/': return 4;
                case '^': return 5;
                default: return 6;
            }
        }

        //"Входной" метод класса
        static public double Calculate(string input)
        {

            string res = input.Replace(" ", "");
            string output = string.Empty;
            double result = 0;

            if (Error1(res) && Error2(res) && Error4(res) && Error5(res) && Error6(res) && Error8(res))
            {
                output = GetExpression(input); //Преобразовываем выражение в постфиксную запись
                result = Counting(output); //Решаем полученное выражение
            }

            return result; //Возвращаем результат
        }

        static private string GetExpression(string input)
        {

            string output = string.Empty; //Строка для хранения выражения
            Stack<char> operStack = new Stack<char>(); //Стек для хранения операторов

            for (int i = 0; i < input.Length; i++) //Для каждого символа в входной строке
            {
                //Разделители пропускаем
                if (IsDelimeter(input[i]))
                    continue; //Переходим к следующему символу

                //Если символ - цифра, то считываем все число
                if (Char.IsDigit(input[i])) //Если цифра
                {
                    //Читаем до разделителя или оператора, что бы получить число
                    while (!IsDelimeter(input[i]) && !IsOperator(input[i]))
                    {
                        output += input[i]; //Добавляем каждую цифру числа к нашей строке
                        i++; //Переходим к следующему символу

                        if (i == input.Length) break; //Если символ - последний, то выходим из цикла
                    }

                    output += " "; //Дописываем после числа пробел в строку с выражением
                    i--; //Возвращаемся на один символ назад, к символу перед разделителем
                }

                //Если символ - оператор
                if (IsOperator(input[i])) //Если оператор
                {
                    if (input[i] == '(') //Если символ - открывающая скобка
                        operStack.Push(input[i]); //Записываем её в стек
                    else if (input[i] == ')') //Если символ - закрывающая скобка
                    {
                        //Выписываем все операторы до открывающей скобки в строку
                        char s = operStack.Pop();

                        while (s != '(')
                        {
                            output += s.ToString() + ' ';
                            s = operStack.Pop();
                        }
                    }
                    else //Если любой другой оператор
                    {
                        if (operStack.Count > 0) //Если в стеке есть элементы
                            if (GetPriority(input[i]) <= GetPriority(operStack.Peek())) //И если приоритет нашего оператора меньше или равен приоритету оператора на вершине стека
                                output += operStack.Pop().ToString() + " "; //То добавляем последний оператор из стека в строку с выражением

                        operStack.Push(char.Parse(input[i].ToString())); //Если стек пуст, или же приоритет оператора выше - добавляем операторов на вершину стека

                    }
                }
            }

            //Когда прошли по всем символам, выкидываем из стека все оставшиеся там операторы в строку
            while (operStack.Count > 0)
                output += operStack.Pop() + " ";

            return output; //Возвращаем выражение в постфиксной записи
        }
        static private double Counting(string input)
        {
            double result = 0; //Результат
            Stack<double> temp = new Stack<double>(); //Тимчасовий стек для решения

            for (int i = 0; i < input.Length; i++) //Для каждого символа в строке
            {
                //Если символ - цифра, то читаем все число и записываем на вершину стека
                if (Char.IsDigit(input[i]))
                {
                    string a = string.Empty;

                    while (!IsDelimeter(input[i]) && !IsOperator(input[i])) //Пока не разделитель
                    {
                        a += input[i]; //Добавляем
                        i++;
                        if (i == input.Length) break;
                    }
                    temp.Push(double.Parse(a)); //Записываем в стек
                    i--;
                }
                else if (IsOperator(input[i])) //Если символ - оператор
                {
                    //Берем два последних значения из стека
                    double a = temp.Pop();
                    double b = temp.Pop();

                    switch (input[i]) //И производим над ними действие, согласно оператору
                    {
                        case '+': result = b + a; break;
                        case '-': result = b - a; break;
                        case '*': result = b * a; break;
                        case '/':
                            {
                                if (a == 0) throw new DivideByZeroException();
                                else result = b / a; break;

                            }

                        case '^': result = double.Parse(Math.Pow(double.Parse(b.ToString()), double.Parse(a.ToString())).ToString()); break;
                    }
                    temp.Push(result); //Результат вычисления записываем обратно в стек

                }
            }
            return temp.Peek(); //Забираем результат всех вычислений из стека и возвращаем его
        }


        /// <summary>
        /// Неправильна структура в дужках
        /// </summary>
        private static bool Error1(string expression)
        {
            //Error 01 at < i > — Неправильна структура в дужках, помилка на<i> символі.  OKK

            Stack<int> stk = new Stack<int>();

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(') stk.Push(i);
                else if (expression[i] == ')')
                {
                    if (stk.Count == 0) throw new Exception(errors[0] + $" на позиції {i}");

                    stk.Pop();
                }
            }

            if (stk.Count != 0) throw new Exception(errors[0] + $" на позиції {stk.Peek()}");

            return true;
        }

        /// <summary>
        ///  Error 02 at < i > — Невідомий оператор на<i> символі.
        /// </summary>
        private static bool Error2(string expression)
        {
            //Error 02 at < i > — Невідомий оператор на<i> символі.

            string op = "+-*/";
            string ingnore = "()[]{}";
            List<char> operators = new List<char>() { '+', '-', '*', '/' };

            //text[i] != '(' && text[i] != ')'
            for (int i = 0; i < expression.Length; i++)
            {
                if (!Char.IsDigit(expression[i]) && ingnore.IndexOf(expression[i]) == -1)
                {
                    if ((op.IndexOf(expression[i]) == -1)) throw new Exception(errors[1] + $" на {i}");
                    //{

                    //    Console.WriteLine(errors[1] + $" на {i}");
                    //    break;
                    //}
                }
            }

            return true;
        }

        /// <summary>
        /// Два підряд оператори на i символі.
        /// </summary>
        private static bool  Error4(string expression)
        {
            string op = "+-*/";

            for (int i = 0; i < expression.Length; i++)
            {
                if (op.IndexOf(expression[i]) != -1 && i + 1 != expression.Length)
                {
                    if (op.IndexOf(expression[i + 1]) != -1)
                    {
                        Console.WriteLine(errors[3] + $" на {i}");
                        break;
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// "Незавершений вираз.",
        /// </summary>
        private static bool Error5(string expression)
        {
            string symb = "(){}[]";
            string operators = "+-*/";

            string tt = string.Empty;

            bool flag = false;

            for (int i = 0; i < expression.Length; i++)
            {
                if (symb.IndexOf(expression[i]) != -1)
                {
                    flag = true;
                    break;
                }
            }

            if (flag)
            {
                string[] test = expression.Split(new char[] { '(', ')', '{', '}', '[', ']' }, expression.Length);
                tt = test.ToString();
            }
            else tt = expression;

            Console.WriteLine(symb.IndexOf(expression[0]));
            Console.WriteLine(symb.IndexOf(expression[expression.Length - 1]));

            if (operators.IndexOf(tt[0]) != -1 || operators.IndexOf(tt[tt.Length - 1]) != -1) throw new Exception(errors[4]);


            return true;
        }

        /// <summary>
        /// Error 06 — Дуже мале, або дуже велике значення числа для int.
        /// Числа повинні бути в межах від -2147483648 до 2147483647.
        /// </summary>
        private static bool Error6(string expression)
        {
            string num = string.Empty;



            for (int i = 0; i < expression.Length; i++)
            {
                if (Char.IsDigit(expression[i]))
                {
                    num += expression[i];
                }
                else
                {
                    if (num != string.Empty)
                    {
                        double number = Convert.ToDouble(num);
                        if (number < -2147483648 || number > 2147483647) throw new Exception(errors[5]); 
                        num = string.Empty;
                    }
                }
            }

      

            return true;

        }

        /// <summary>
        /// Сумарна кiлькiсть чисел i операторiв перевищує 30.",
        /// </summary>
        private static bool Error8(string expression)
        {
            string num = string.Empty;
            string operatores = "+/*-";

            ArrayList ar = new ArrayList();

            for (int i = 0; i < expression.Length; i++)
            {
                if (Char.IsDigit(expression[i]))
                {
                    num += expression[i];
                }
                else
                {
                    if (num != string.Empty)
                    {
                        ar.Add(Convert.ToInt32(num));
                        num = string.Empty;
                    }
                }

                if (operatores.IndexOf(expression[i]) != -1) ar.Add(expression[i]);
            }

            if (ar.Count > 30) throw new Exception(errors[7]);

            return true;
        }
    }
}
