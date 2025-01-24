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
    public class GreaterThanController : ControllerBase
    {
        private readonly GreaterThanServices _greaterThanServices;
        public GreaterThanController(GreaterThanServices greaterThanServices){
            _greaterThanServices = greaterThanServices;
        }
        [HttpPost]
        [Route("GreaterThan/{firstNum}/{secondNum}")]
        public string UpdateComparison(string firstNum, string secondNum){
            return _greaterThanServices.UpdateComparison(firstNum, secondNum);
        }
    }
}