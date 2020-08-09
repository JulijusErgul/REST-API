using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST_API.Models
{
    public class TaskList
    {
        public int TaskListId { get; set; }
        public string TaskListName { get; set; }
        public string TaskListDescription { get; set; }
        public int TaskCount { get; set; }
    }
}
