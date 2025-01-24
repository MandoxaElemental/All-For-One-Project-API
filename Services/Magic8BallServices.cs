using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace All_For_One_Project_API.Services
{
    public class Magic8BallServices
    {
         public string resultList = "";
        public Random rng = new Random();
        public string[] answers = { 
            "Hudda hudda huuh!", 
            "Mmmmmmmrrrrrrrpppghhh!", 
            "Mmmrpgh crpyha drghya!", 
            "Mhhhhoooooo!", 
            "Hurrururururu!", 
            "Heh dum dummad",
            "Buh, budda, bah!",
            "(laughs) Hef huv there, huh!",
            "Mhnk nhya mhph."};
        public string YourQuestion(string userInput)
        {
            int ourRandomNumber = rng.Next(0, 9);
            resultList = $"{userInput} - {answers[ourRandomNumber]}";
            return resultList;

        }
    }
}