using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using CalcLibrary;

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

        /// <summary>
        /// Метод возвращает true, если проверяемый символ - разделитель ("пробел" или "равно")
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        /// 
        static private bool IsDelimeter(char c)
        {
            if ((" =".IndexOf(c) != -1))
                return true;
            return false;
        }

        /// <summary>
        /// Метод возвращает true, если проверяемый символ - оператор
        /// </summary>
        /// <param name="с"></param>
        /// <returns></returns>
        static private bool IsOperator(char с)
        {
            if (("+-/*^()".IndexOf(с) != -1))
                return true;
            return false;
        }

        /// <summary>
        /// Метод возвращает приоритет оператора
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
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
        static public double Calculate(string input)
        {
            string res = input.Replace(" ", "");
            string output = string.Empty;
            double result = 0;

            if (Error1(res) && Error2(res) && Error4(res) && Error5(res) && Error6(res) && Error7(res) && Error8(res))
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

                if (input[i] == '(') //Перевіяєм чи є відємне число
                {

                    int index = input.IndexOf(')', i);

                    string tmp = input.Substring(i, index - i + 1);


                    Regex regex = new Regex(@"\([-](.\d*)\)");

                    if (regex.IsMatch(tmp))
                    {
                        Match match = Regex.Match(tmp, @"\([-](.\d*)\)");

                        double n = Convert.ToDouble(match.Groups[1].Value);

                        output += -n;
                        i = index + 1;
                    }
                    output += " ";
                }


                if (i >= input.Length) break;

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
                if (input[i] == '-' && Char.IsDigit(input[i + 1]))
                {
                    string a = "-";
                    i++;

                    while (!IsDelimeter(input[i]) && !IsOperator(input[i])) //Пока не разделитель
                    {
                        a += input[i]; //Добавляем
                        i++;
                        if (i == input.Length) break;
                    }
                    temp.Push(double.Parse(a)); //Записываем в стек
                    i--;
                }
                else
                {
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
                            case '+': result = Calc.Add(b, a); break;
                            case '-': result = Calc.Sub(b, a); break;
                            case '*': result = Calc.Mult(b, a); break;
                            case '/':
                                {
                                    if (a == 0) throw new Exception(errors[8]);
                                    else result = Calc.Div(b, a); break;
                                }
                        }
                        temp.Push(result); //Результат вычисления записываем обратно в стек
                    }
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
        ///  Error 02 — Невідомий оператор на i символі.
        /// </summary>
        private static bool Error2(string expression)
        {
            //Error 02 at < i > — Невідомий оператор на<i> символі.

            string op = "+-*/";
            string ingnore = "()[]{}";
            List<char> operators = new List<char>() { '+', '-', '*', '/' };

            for (int i = 0; i < expression.Length; i++)
                if (!Char.IsDigit(expression[i]) && ingnore.IndexOf(expression[i]) == -1)
                    if ((op.IndexOf(expression[i]) == -1)) throw new Exception(errors[1] + $" на {i}");

            return true;
        }


        /// <summary>
        /// Невiрна синтаксична конструкцiя вхiдного виразу.,
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        private static bool Error3(string expression)
        {
            string op = "+/*-";
            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    if (i == 0) continue;
                    else if (op.IndexOf(expression[i - 1]) == -1) throw new Exception(errors[2]);
                }
            }

            return true;
        }

        /// <summary>
        /// Два підряд оператори на i символі.
        /// </summary>
        private static bool Error4(string expression)
        {
            string op = "+-*/";

            for (int i = 0; i < expression.Length; i++)
                if (op.IndexOf(expression[i]) != -1 && i + 1 != expression.Length)
                    if (op.IndexOf(expression[i + 1]) != -1) throw new Exception(errors[3]);

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
        /// Дуже довгий вираз. Максмальная довжина — 65536 символiв.
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        private static bool Error7(string expression)
        {
            if (expression.Length > 65536) throw new Exception(errors[6]);

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
