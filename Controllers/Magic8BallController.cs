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
    public class Magic8BallController : ControllerBase
    {
        private readonly Magic8BallServices _magic8BallServices;
        public Magic8BallController(Magic8BallServices magic8BallServices){
            _magic8BallServices = magic8BallServices;
        }
        [HttpGet]
        [Route("Magic8Ball/{userInput}")]
        public string Magic8BallResponse(string userInput){
            return _magic8BallServices.YourQuestion(userInput);
        }
    }
}