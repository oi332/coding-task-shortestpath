using CodingTaskArrays.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTaskArrays.DAL
{
    public interface INumbersArrayRepository
    {
        IEnumerable<NumbersArrayEntity> GetAll();
        NumbersArrayEntity GetById(int id);
        void Create(NumbersArrayEntity numbersArrayEntity);
    }
}
