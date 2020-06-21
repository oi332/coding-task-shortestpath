using CodingTaskArrays.BLL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CodingTaskArrays.BLL.Services
{
    public interface INumbersArrayService
    {
         NumbersArrayDto Validate(NumbersArrayDto numbersArrayDto);
    }
}
