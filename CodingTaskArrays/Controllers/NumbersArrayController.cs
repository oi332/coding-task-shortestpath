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

        [HttpPost]
        public ActionResult Post([FromBody] NumbersArrayRequest numbersArrayRequest)
        {
            var numbersArrayDto = _numbersArrayService.Validate(numbersArrayRequest.ToDto());

            return Ok(numbersArrayDto.ToResponse());
        }
    }
}
