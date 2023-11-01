using GenHomeWork.NumberConvert;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenHomeWork.Model
{
    public class CurrentTask7 : TaskBase
    {
        public int initialNumber;
        public int lastNumber;

        public int numericSystem1;
        public int numericSystem2;
        public int numericSystem3;

        public int countTask;

        public void GenerateTaskAndSolutions()
        {
            var tasks = new List<string>();
            var solutions = new List<string>();

            var count = 0;

            var numSys1 = numericSystem1;
            var numSys2 = numericSystem2;
            var numSys3 = numericSystem3;

            var flag = true;

            Random random = new Random();

            for (int i = 0; i < countTask; i++)
            {
                var numbers = new string[6, 2];
                var numDecimal = new int[6];

                for (int k = 0; k < numDecimal.Length; k++)
                { 
                    numDecimal[k] = random.Next(initialNumber, lastNumber + 1);
                    do
                    {
                         numDecimal[5] = random.Next(initialNumber, lastNumber + 1);
                        
                    } while (numDecimal[4] > numDecimal[5]);
                }

                for (int j = 0; j < numbers.GetLength(0) - 2; j++)
                {

                    if (numericSystem1 == 0)
                    {
                        var ch = random.Next(1, 4);

                        if (ch == 1) { numSys1 = 2; }
                        else if (ch == 2) { numSys1 = 8; }
                        else if (ch == 3) { numSys1 = 16; }
                    }
                    numbers[j, 0] = NumberConverter.ConvertBase(numDecimal[j].ToString(), 10, numSys1);
                    numbers[j, 1] = numSys1.ToString();

                    if (numericSystem2 == 0 && numSys2 == 0)
                    {
                        var ch = random.Next(1, 4);
                        if (ch == 1) { numSys2 = 2; }
                        else if (ch == 2) { numSys2 = 8; }
                        else if (ch == 3) { numSys2 = 16; }

                        numbers[4, 0] = NumberConverter.ConvertBase(numDecimal[4].ToString(), 10, numSys2);
                        numbers[4, 1] = numSys2.ToString();
                    }
                    else if (numbers[4, 0] == null)
                    {
                        numbers[4, 0] = NumberConverter.ConvertBase(numDecimal[4].ToString(), 10, numericSystem2);
                        numbers[4, 1] = numericSystem2.ToString();
                    }

                    if (numericSystem3 == 0 && numSys3 == 0)
                    {
                        var ch = random.Next(1, 4);
                        if (ch == 1) { numSys3 = 2; }
                        else if (ch == 2) { numSys3 = 8; }
                        else if (ch == 3) { numSys3 = 16; }

                        numbers[5, 0] = NumberConverter.ConvertBase(numDecimal[5].ToString(), 10, numSys3);
                        numbers[5, 1] = numSys3.ToString();
                    }
                    else if (numbers[5, 0] == null)
                    {
                        numbers[5, 0] = NumberConverter.ConvertBase(numDecimal[5].ToString(), 10, numericSystem3);
                        numbers[5, 1] = numericSystem3.ToString();
                    }
                }

                for (int k = 0; k < numDecimal.Length - 2; k++)
                {
                    if (numDecimal[k] > numDecimal[4] && numDecimal[k] < numDecimal[5])
                    {
                        count++;
                    }
                }

                if (flag)
                {
                    tasks.Add($"\nТип {TemplateManager.CounterType + 1}");
                    solutions.Add($"\nТип {TemplateManager.CounterType + 1}");
                    TemplateManager.CounterType++;
                    flag = false;
                }

                var task = $"{i + 1}. Даны 4 целых числа, записанные в различных системах счисления: {numbers[0, 0]} в {numbers[0, 1]} системе счисления, " +
                        $"{numbers[1, 0]} в {numbers[1, 1]} системе счисления, {numbers[2, 0]} в {numbers[2, 1]} системе счисления, {numbers[3, 0]}, в {numbers[3, 1]} системе счисления. " +
                        $"Сколько среди них чисел, значение которых лежит между {numbers[4, 0]} в {numbers[4, 1]} системе счисления и {numbers[5, 0]} в {numbers[5, 1]} системе счисления";

                var solution = $"{task}\nРешение: {count} числ., лежит между {numbers[4, 0]} (({numDecimal[4]}) ) и {numbers[5, 0]} ({numDecimal[5]}) " +
                    $" ({numDecimal[0]}, {numDecimal[1]}, {numDecimal[2]}, {numDecimal[3]})";

                tasks.Add(task);
                solutions.Add(solution);

                count = 0;
                numSys2 = 0;
                numSys3 = 0;
            }

            TemplateManager.AddTaskAndSolutionInResultList(tasks, solutions);
        }
    }
}
