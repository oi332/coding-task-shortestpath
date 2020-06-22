using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CodingTaskArrays.Models
{
    public class NumbersArrayRequest
    {
        [JsonPropertyName("numbers")]
        public List<int> Numbers { get; set; }
    }
}
