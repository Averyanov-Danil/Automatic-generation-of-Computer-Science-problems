using GenHomeWork.NumberConvert;
using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace GenHomeWork.Model
{
    public class CurrentTask6 : TaskBase
    {
        public int initialNum;
        public int lastNum;
        
        public int moreOrLess;
        public int numericSystem;

        public int countTask;

        public void GenerateTaskAndSolutions()
        {
            var tasks = new List<string>();
            var solutions = new List<string>();

            
            var count = 0;
            Random random = new Random();

            var sys = numericSystem;
            var mol = moreOrLess;
            var numbers = new string[5, 2];
            var numDecimal = new int[5];
            var flag = true;

            for (int i = 0; i < countTask; i++)
            {
                numbers = new string[5, 2];
                numDecimal = new int[5];

                for (int k = 0; k < numDecimal.Length; k++) { numDecimal[k] = random.Next(initialNum, lastNum + 1); }
                if (moreOrLess == 0)
                {
                    mol = random.Next(1, 3);
                }

                for (int j = 0; j < numbers.GetLength(0); j++)
                {
                    if (numericSystem == 0)
                    {
                        var ch = random.Next(1, 4);

                        if (ch == 1) { sys = 2; }
                        else if (ch == 2) { sys = 8; }
                        else if (ch == 3) { sys = 16; }
                    }
                    numbers[j, 0] = NumberConverter.ConvertBase(numDecimal[j].ToString(), 10, sys);
                    numbers[j, 1] = sys.ToString();
                }

                for (int j = 0; j < numDecimal.Length - 1; j++)
                {
                    if (mol == 1) // more
                    {
                        if (numDecimal[4] > numDecimal[j])
                        {
                            count++;
                        }
                    }
                    else if (mol == 2) // lessuka
                    {
                        if (numDecimal[4] < numDecimal[j])
                        {
                            count++;
                        }
                    }
                }

                if (mol == 1) // more
                {
                    if (flag)
                    {
                        tasks.Add($"Тип {TemplateManager.CounterType + 1}");
                        solutions.Add($"Тип {TemplateManager.CounterType + 1}");
                        TemplateManager.CounterType++;
                        flag = false;
                    }
                    var task = $"{i + 1}. Даны 4 целых числа, записанные в различных системах счисления: {numbers[0, 0]} в {numbers[0, 1]} системе счисления, " +
                        $"{numbers[1, 0]} в {numbers[1, 1]} системе счисления, {numbers[2, 0]} в {numbers[2, 1]} системе счисления, {numbers[3, 0]}, в {numbers[3, 1]} системе счисления. " +
                        $"Сколько среди них чисел, которые меньше чем {numbers[4, 0]} в {numbers[4, 1]} системе счисления";

                    var solution = $"{task}\nРешение: {count} чисел меньше чем {numbers[4,0]} ({numDecimal[4]}) " +
                        $" ({numDecimal[0]}, {numDecimal[1]}, {numDecimal[2]}, {numDecimal[3]})";
                    
                    tasks.Add(task);
                    solutions.Add(solution);
                    count = 0;
                    numbers = null;
                    numDecimal = null;
                }
                else if (mol == 2) // less
                {
                    if (flag)
                    {
                        tasks.Add($"Тип {TemplateManager.CounterType + 1}");
                        solutions.Add($"Тип {TemplateManager.CounterType + 1}");
                        TemplateManager.CounterType++;
                        flag = false;
                    }
                    var task = $"{i + 1}. Даны 4 целых числа, записанные в различных системах счисления: {numbers[0, 0]} в {numbers[0, 1]} системе счисления," +
                        $" {numbers[1, 0]} в {numbers[1, 1]} системе счисления, {numbers[2, 0]} в {numbers[2, 1]} системе счисления, {numbers[3, 0]}, в {numbers[3, 1]} системе счисления." +
                        $" Сколько среди них чисел, которые больше чем {numbers[4, 0]} в {numbers[4, 1]}";

                    var solution = $"{task}\nРешение: {count} чисел больше чем {numbers[4, 0]} ({numDecimal[4]})  " +
                        $"({numDecimal[0]}, {numDecimal[1]}, {numDecimal[2]}, {numDecimal[3]})";

                    tasks.Add(task);
                    solutions.Add(solution);
                    count = 0;
                    numbers = null;
                    numDecimal = null;
                }
            }
            TemplateManager.AddTaskAndSolutionInResultList(tasks, solutions);
        }
    }
}
