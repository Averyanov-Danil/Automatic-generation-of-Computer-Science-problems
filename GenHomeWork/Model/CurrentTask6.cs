using GenHomeWork.NumberConvert;
using System;
using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace GenHomeWork.Model
{
    public class CurrentTask6 : TaskBase
    {
        public int initialNum;
        public int lastNum;
        
        public int moreOrLess;
        public int numericSystem;
        public int numericSystem2;

        public int countTask;

        public void GenerateTaskAndSolutions()
        {
            var tasks = new List<string>();
            var solutions = new List<string>();

            
            var count = 0;
            Random random = new Random();

            var sys = numericSystem;
            var sys2 = numericSystem2;
            var sign = moreOrLess;
            var flag = true;

            for (int i = 0; i < countTask; i++)
            {
                var numbers = new string[5, 2];
                var numDecimal = new int[5];

                for (int k = 0; k < numDecimal.Length; k++) { numDecimal[k] = random.Next(initialNum, lastNum + 1); }
                if (moreOrLess == 0)
                {
                    sign = random.Next(1, 3);
                }

                for (int j = 0; j < numbers.GetLength(0) - 1; j++)
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

                    if (numericSystem2 == 0 && sys2 == 0)
                    {
                        var ch = random.Next(1, 4);
                        if (ch == 1) { sys2 = 2; }
                        else if (ch == 2) { sys2 = 8; }
                        else if (ch == 3) { sys2 = 16; }

                        numbers[4, 0] = NumberConverter.ConvertBase(numDecimal[4].ToString(), 10, sys2);
                        numbers[4, 1] = sys2.ToString();
                    }
                    else if (numbers[4,0] == null)
                    {
                        numbers[4, 0] = NumberConverter.ConvertBase(numDecimal[4].ToString(), 10, numericSystem2);
                        numbers[4, 1] = numericSystem2.ToString();
                    }
                }

                for (int j = 0; j < numDecimal.Length - 1; j++)
                {
                    if (sign == 1) // more
                    {
                        if (numDecimal[4] > numDecimal[j])
                        {
                            count++;
                        }
                    }
                    else if (sign == 2) // lessuka
                    {
                        if (numDecimal[4] < numDecimal[j])
                        {
                            count++;
                        }
                    }
                }

                if (sign == 1) // more
                {
                    if (flag)
                    {
                        tasks.Add($"\nТип {TemplateManager.CounterType + 1}");
                        solutions.Add($"\nТип {TemplateManager.CounterType + 1}");
                        TemplateManager.CounterType++;
                        flag = false;
                    }
                    var task = $"{i + 1}. Даны 4 целых числа, записанные в различных системах счисления: {numbers[0, 0]} в {numbers[0, 1]} системе счисления, " +
                        $"{numbers[1, 0]} в {numbers[1, 1]} системе счисления, {numbers[2, 0]} в {numbers[2, 1]} системе счисления, {numbers[3, 0]}, в {numbers[3, 1]} системе счисления. " +
                        $"Сколько среди них чисел, которые меньше, чем {numbers[4, 0]} в {numbers[4, 1]} системе счисления";

                    var solution = $"{task}\nРешение: {count} числ. меньше, чем {numbers[4,0]} ({numDecimal[4]}) " +
                        $" ({numDecimal[0]}, {numDecimal[1]}, {numDecimal[2]}, {numDecimal[3]})";
                    
                    tasks.Add(task);
                    solutions.Add(solution);
                    count = 0;
                    sys2 = 0;
                }
                else if (sign == 2) // less
                {
                    if (flag)
                    {
                        tasks.Add($"\nТип {TemplateManager.CounterType + 1}");
                        solutions.Add($"\nТип {TemplateManager.CounterType + 1}");
                        TemplateManager.CounterType++;
                        flag = false;
                    }
                    var task = $"{i + 1}. Даны 4 целых числа, записанные в различных системах счисления: {numbers[0, 0]} в {numbers[0, 1]} системе счисления," +
                        $" {numbers[1, 0]} в {numbers[1, 1]} системе счисления, {numbers[2, 0]} в {numbers[2, 1]} системе счисления, {numbers[3, 0]}, в {numbers[3, 1]} системе счисления." +
                        $" Сколько среди них чисел, которые больше, чем {numbers[4, 0]} в {numbers[4, 1]}  системе счисления";

                    var solution = $"{task}\nРешение: {count} числ. больше, чем {numbers[4, 0]} ({numDecimal[4]})  " +
                        $"({numDecimal[0]}, {numDecimal[1]}, {numDecimal[2]}, {numDecimal[3]})";

                    tasks.Add(task);
                    solutions.Add(solution);
                    count = 0;
                    sys2 = 0;
                }
            }
            TemplateManager.AddTaskAndSolutionInResultList(tasks, solutions);
        }
    }
}
