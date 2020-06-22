using CodingTaskArrays.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingTaskArrays.DAL
{
    public class NumbersArrayRepository : INumbersArrayRepository
    {
        private List<NumbersArrayEntity> NumbersArrayEntities = new List<NumbersArrayEntity> { };

        public IEnumerable<NumbersArrayEntity> GetAll()
        {
            return NumbersArrayEntities.AsReadOnly();
        }

        public NumbersArrayEntity GetById(int id)
        {
            var numbersArrayEntity = NumbersArrayEntities.FirstOrDefault(nae => nae.Id == id);

            return numbersArrayEntity;
        }

        public void Create(NumbersArrayEntity numbersArrayEntity)
        {
            NumbersArrayEntities.Add(numbersArrayEntity);
        }
    }
}
