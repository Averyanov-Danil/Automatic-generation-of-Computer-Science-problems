using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenHomeWork.Model
{
    [Serializable]
    public class Template
    {
        public string Name { get; set; }
        public List<TaskBase> Tasks { get; set; }
    }
}
