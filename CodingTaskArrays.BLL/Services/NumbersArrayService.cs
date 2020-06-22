using CodingTaskArrays.BLL.Models;
using CodingTaskArrays.BLL.Models.Extensions;
using CodingTaskArrays.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTaskArrays.BLL.Services
{
    public class NumbersArrayService : INumbersArrayService
    {
        private readonly INumbersArrayRepository _numbersArrayRepository;

        public NumbersArrayService(INumbersArrayRepository numbersArrayRepository)
        {
            _numbersArrayRepository = numbersArrayRepository;
        }

        public void Create(NumbersArrayDto numbersArrayDto)
        {
            var graph = GraphBuilder.Build(numbersArrayDto);
            var shortestPath = ShortestPathFinder.FindShortestPathFromStartToEndBFS(graph);

            numbersArrayDto.ShortestPath = shortestPath;

            // not very good, but okay at the moment
            var newId = _numbersArrayRepository.GetAll().Count() + 1;

            _numbersArrayRepository.Create(numbersArrayDto.ToEntity(newId));
        }

        public IEnumerable<NumbersArrayDto> GetAll()
        {
            return _numbersArrayRepository.GetAll().ToDtos();
        }

        public NumbersArrayDto GetById(int id)
        {
            var numbersArrayEntity = _numbersArrayRepository.GetById(id);

            return numbersArrayEntity != null ? numbersArrayEntity.ToDto() : null;
        }
    }
}
