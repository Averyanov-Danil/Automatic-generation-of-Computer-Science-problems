using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenHomeWork.Model
{
    [Serializable]
    public abstract class TaskBase
    {
        public string Type { get; set; }
    }
}
