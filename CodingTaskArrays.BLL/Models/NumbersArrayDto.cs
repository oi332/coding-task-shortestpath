using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTaskArrays.BLL.Models
{
    public class NumbersArrayDto
    {
        public int Id { get; set; }
        public List<int> Numbers { get; set; }
        public List<int> ShortestPath { get; set; }
    }
}
