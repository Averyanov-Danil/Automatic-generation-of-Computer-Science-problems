using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenHomeWork.SupportClasses
{
    public class FolderHelper
    {
        private static string taskPath = Properties.Settings.Default.TaskPath;
        private static string solutionPath = Properties.Settings.Default.TaskPath;

        public static string TaskPath
        {
            get { return taskPath; }
            set
            {
                taskPath = value;
                Properties.Settings.Default.TaskPath = value;
                Properties.Settings.Default.Save();
            }
        }

        public static string SolutionPath
        {
            get { return solutionPath; }
            set
            {
                solutionPath = value;
                Properties.Settings.Default.SolutionPath = value;
                Properties.Settings.Default.Save(); 
            }
        }
    }
}
