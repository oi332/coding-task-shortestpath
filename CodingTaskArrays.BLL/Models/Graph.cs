using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTaskArrays.BLL.Validators.Models
{
    public class Graph
    {
        public Dictionary<int, HashSet<int>> Relations { get; set; }
    }
}
