using GenHomeWork.ViewController;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.TextFormatting;

namespace GenHomeWork.Model
{
    public static class TemplateManager
    {
        private static string templateFilePath = "templates.json";

        /// <summary>
        /// Храним задачи. Будут использоваться для дальнейшего добавления в новый шаблон(очищается после создания шаблона с ними)
        /// </summary>
        private static List<TaskBase> tasksStatic = new List<TaskBase>();
        /// <summary>
        /// Новые шаблоны(те, которые были добавлены до выгрузки остальных из файла)
        /// </summary>
        private static List<Template> templatesNew = new List<Template>();
        /// <summary>
        /// Основной лист шаблонов(при выгрузки к нему добавляются новые)
        /// </summary>
        private static List<Template> templates = new List<Template>();

        /// <summary>
        /// Храним уже готовые задачи
        /// </summary>
        public static List<string> tasks;
        /// <summary>
        /// Храним решение к задачкам
        /// </summary>
        public static List<string> solution;

        public static int CounterType = 0;
        
        public static List<Template> Templates { get {  return templates; } }

        public static void AddTask(TaskBase task)
        {
            tasksStatic.Add(task);
        }

        public static void AddTaskAndSolutionInResultList(List<string> taskStr, List<string> solutionStr)
        {
            if (tasks == null || solution == null)
            {
                tasks = new List<string>();
                solution = new List<string>();
            }

            foreach (var task in taskStr)
            {
                tasks.Add(task);
            }

            foreach (var sol in solutionStr)
            {
                solution.Add(sol);
            }
        }

        public static void PrintToFile(string filePath, string title)
        {
            SaveToFile.SaveToWordFile(filePath + $" {title} Задачи.docx", title, tasks);
            SaveToFile.SaveToWordFile(filePath + $" {title} Решение.docx", title, solution);
            tasks.Clear();
            solution.Clear();
            CounterType = 0;
        }

        public static Template CreateTemplate(string name)
        {
            var template = new Template
            {
                Name = name,
                Tasks = new List<TaskBase>(tasksStatic),
            };

            templatesNew.Add(template);
            tasksStatic.Clear();

            return template;
        }

        public static void SaveTemplates()
        {
            string jsonData = JsonConvert.SerializeObject(templates, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All // Сохранять информацию о типе
            });
            File.WriteAllText(templateFilePath, jsonData);
        }

        public static void DeleteTemplate(string name)
        {
            foreach (var template in templates)
            {
                if (template.Name == name)
                {
                    templates.Remove(template);
                    SaveTemplates();
                    break;
                }
            }
            CreateFormManager.FillGrid(templates);
        }

        public static void SelectTemplate(string selectedName, string pathQuest, string pathSolution)
        {
            foreach (var template in templates )
            {
                if (template.Name == selectedName)
                {
                    foreach (var task in template.Tasks)
                    {
                        if (task.Type == "Task1")
                        {
                            var one = (CurrentTask1)task;
                            one.GenerateAndSaveTasks();
                        }
                        else if (task.Type == "Task2")
                        {
                            var two = (CurrentTask2)task;
                            two.GenerateTasksAndSolutions();
                        }
                        else if (task.Type == "Task3")
                        {
                            var three = (CurrentTask3)task;
                            three.GenerateTasksAndSolutions();
                        }
                        else if (task.Type == "Task4")
                        {
                            var four = (CurrentTask4)task;
                            four.GenerateTasksAndSolutions();
                        }
                        else if (task.Type == "Task5")
                        {
                            var five = (CurrentTask5)task;
                            five.GenerateTasksAndSolutions();
                        }
                        else if(task.Type == "Task6")
                        {
                            var six = (CurrentTask6)task;
                            six.GenerateTaskAndSolutions();
                        }
                    }
                    PrintToFile(pathQuest, "Шаблон " + selectedName);
                }
            }
        }

        public static List<Template> LoadTemplates()
        {
            if (File.Exists(templateFilePath))
            {
                string jsonData = File.ReadAllText(templateFilePath);
                if (jsonData != null)
                {
                    templates = JsonConvert.DeserializeObject<List<Template>>(jsonData, new JsonSerializerSettings
                    {
                        TypeNameHandling = TypeNameHandling.All // Загружать информацию о типе
                    });
                    if (templates == null ||templates.Count == 0)
                    {
                        templates = templatesNew;
                        SaveTemplates();
                        return templates;
                    }
                }
                else { 
                    templates = templatesNew;
                    SaveTemplates();
                    return templates;
                }
            }
            else
            {
                // Если файл не существует, создать новый список шаблонов
                templates = new List<Template>();
            }

            AddNewTemplate();
            SaveTemplates();
            return templates;
        }

        private static void AddNewTemplate()
        {
            templatesNew.Reverse();
            foreach (var template in templatesNew)
            {
                templates.Add(template);
            }
        }
    }
}
