using System;
using System.Collections.Generic;
using System.Linq;

namespace H.W_16__13._03_
{
    class Program
    {
        static void Main(string[] args)
        {

            //Первый элемент Количество положительных чисел, а второй элемент - сумма отрицательных чисел.
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15 };
            var positiveNumbers = numbers.Where(x => x > 0).Count();
            var negativeNumbers = numbers.Where(x => x < 0).Sum();

            Console.WriteLine(positiveNumbers);
            Console.WriteLine(negativeNumbers);

            //Возвращаем уникальное число
            int[] uniqeNum = { 4, 1, 4, 4, 4, 4 };
            var a = uniqeNum.GroupBy(n => n).Select(g => g.Count() == 1 ? g.Key : 0).Max();
            Console.WriteLine(a);

            double[] uniqeNum1 = { 0, 0, 0.55, 0, 0 };
            var a1 = uniqeNum.GroupBy(n => n).Select(g => g.Count() == 1 ? g.Key : 0).Max();
            Console.WriteLine(a1);

            //От самой короткой до самой длинной
            string[] vocabulary = { "Telescopes", "Glasses", "Eyes", "Monocles" };
            IEnumerable<string> words = vocabulary.OrderByDescending(v => v);
            foreach (var item in words)
            {
                Console.WriteLine(item);
            }


            //Reverse
            int[] numbers = { 2, 5, 7, 4, 8, 2 };
            IEnumerable<int> res = numbers.Reverse();

            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
        }
    }
}
