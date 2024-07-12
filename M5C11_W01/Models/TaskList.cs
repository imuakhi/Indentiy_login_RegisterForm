using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace M5C11_W01.Models
{
    public class TaskList
    {
        public int Id { get; set; }
        public string TaskName { get; set; }
        public string Description { get; set; }
        public string Submitedby { get; set; }
    }
}