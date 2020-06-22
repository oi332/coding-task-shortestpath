using CodingTaskArrays.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingTaskArrays.BLL.Models.Extensions
{
    public static class NumbersArrayDtoExtensions
    {
        public static NumbersArrayEntity ToEntity(this NumbersArrayDto numbersArrayDto, int id)
        {
            return new NumbersArrayEntity
            {
                Id = id,
                Numbers = numbersArrayDto.Numbers,
                ShortestPath = numbersArrayDto.ShortestPath
            };
        }

        public static IEnumerable<NumbersArrayDto> ToDtos(this IEnumerable<NumbersArrayEntity> numbersArrayEntities)
        {
            return numbersArrayEntities.Select(nae => new NumbersArrayDto
            {
                Id = nae.Id,
                Numbers = nae.Numbers,
                ShortestPath = nae.ShortestPath
            });
        }

        public static NumbersArrayDto ToDto(this NumbersArrayEntity numbersArrayEntity)
        {
            return new NumbersArrayDto
            {
                Id = numbersArrayEntity.Id,
                Numbers = numbersArrayEntity.Numbers,
                ShortestPath = numbersArrayEntity.ShortestPath
            };
        }
    }
}
