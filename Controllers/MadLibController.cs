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
    public class MadLibController : ControllerBase
    {
        private readonly MadLibServices _madLibServices;
        public MadLibController(MadLibServices madLibServices){
            _madLibServices = madLibServices;
        }
        [HttpGet]
        [Route("MadLib{color}/{pluralNoun1}/{place}/{verb1}/{verb2}/{noun1}/{adjective1}/{pluralObject}/{noun2}/{verb3}/{pluralNoun2}/{adjective2}/{pluralNoun3}/{adverb1}/{verb4}/{adverb2}")]
         public string YourMadLib(string color ,
        string pluralNoun1 ,
        string place ,
        string verb1 ,
        string verb2 ,
        string noun1 ,
        string adjective1 ,
        string pluralObject ,
        string noun2 ,
        string verb3 ,
        string pluralNoun2 ,
        string adjective2 ,
        string pluralNoun3 ,
        string adverb1 ,
        string verb4 ,
        string adverb2)
        {
            return _madLibServices.AddToMadLibList(
        color ,
         pluralNoun1 ,
         place ,
         verb1 ,
         verb2 ,
         noun1 ,
         adjective1 ,
         pluralObject ,
         noun2 ,
         verb3 ,
         pluralNoun2 ,
         adjective2 ,
         pluralNoun3 ,
         adverb1 ,
         verb4 ,
         adverb2);
        }
    }
}