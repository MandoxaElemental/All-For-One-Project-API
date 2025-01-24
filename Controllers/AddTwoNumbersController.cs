using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using All_For_One_Project_API.Services;
using Microsoft.AspNetCore.Mvc;

namespace All_For_One_Project_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddTwoNumbersController : ControllerBase
    {
        private readonly AddTwoNumbersServices _addTwoNumbersServices;
        public AddTwoNumbersController(AddTwoNumbersServices addTwoNumbersServices){
            _addTwoNumbersServices = addTwoNumbersServices;
        }
        [HttpGet]
        [Route("AddTwoNumbers/{numberOne}/{numberTwo}")]
        public string AddTwoNumbersFunction(string numberOne, string numberTwo){
            return _addTwoNumbersServices.AddNumbers(numberOne, numberTwo);
        }
    }
}