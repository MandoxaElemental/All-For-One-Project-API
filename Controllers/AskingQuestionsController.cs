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
    public class AskingQuestionsController : ControllerBase
    {
         private readonly AskingQuestionsServices _askingQuestionsServices;
        public AskingQuestionsController(AskingQuestionsServices askingQuestionsServices){
            _askingQuestionsServices = askingQuestionsServices;
        }
        [HttpPost]
        [Route("AskingQuestions/{name}/{time}")]
        public string Question(string name, string time){
            return _askingQuestionsServices.FinalQuestion(name, time);
        }
    }
}