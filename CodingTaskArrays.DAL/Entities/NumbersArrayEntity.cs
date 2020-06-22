using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTaskArrays.DAL.Entities
{
    public class NumbersArrayEntity
    {
        public int Id { get; set; }
        public List<int> Numbers { get; set; }
        public List<int> ShortestPath { get; set; }
    }
}
