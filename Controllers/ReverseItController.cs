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
    public class ReverseItController : ControllerBase
    {
         private readonly ReverseItAlphanumericalServices _reverseItAlphaNumericalServices;
        private readonly ReverseItNumericalServices _reverseItNumbericalServices;
        public ReverseItController(ReverseItAlphanumericalServices reverseItAlphaNumericalServices, ReverseItNumericalServices reverseItNumbericalServices){
            _reverseItAlphaNumericalServices = reverseItAlphaNumericalServices;
            _reverseItNumbericalServices = reverseItNumbericalServices;
        }
        [HttpPost]
        [Route("ReversedWord/{userInput}")]
         public string ReversedWord(string userInput){
            return _reverseItAlphaNumericalServices.ReversedString(userInput);
         }
         [HttpPost]
        [Route("ReversedNum/{userInput}")]
         public string ReversedNum(string userInput){
            return _reverseItNumbericalServices.ReversedNum(userInput);
         }
    }
}