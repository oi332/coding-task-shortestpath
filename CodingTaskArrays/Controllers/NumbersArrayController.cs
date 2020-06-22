using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodingTaskArrays.BLL.Services;
using CodingTaskArrays.Models;
using CodingTaskArrays.Models.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodingTaskArrays.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NumbersArrayController : ControllerBase
    {
        private readonly INumbersArrayService _numbersArrayService;

        public NumbersArrayController(INumbersArrayService numbersArrayService)
        {
            _numbersArrayService = numbersArrayService;
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var numbersArrayDto = _numbersArrayService.GetById(id);

            if (numbersArrayDto == null)
            {
                return NotFound();
            }

            return Ok(numbersArrayDto.ToResponse());
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            var numbersArrayDto = _numbersArrayService.GetAll();

            return Ok(numbersArrayDto.ToResponse());
        }

        [HttpPost]
        public ActionResult Post([FromBody] NumbersArrayRequest numbersArrayRequest)
        {
            _numbersArrayService.Create(numbersArrayRequest.ToDto());
            
            return Ok();
        }
    }
}
