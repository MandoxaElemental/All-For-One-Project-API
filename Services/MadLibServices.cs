using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace All_For_One_Project_API.Services
{
    public class MadLibServices
    {
        public string madLibList = "";
        public string AddToMadLibList(string color ,
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
            madLibList = $"Attention, mercenaries. We have a critical mission for you. Your target is a group of {color} {pluralNoun1} that have been spotted at the {place}. Your objective is to {verb1} them before they can {verb2} our precious {noun1}. You will be supplied with special {adjective1} {pluralObject} and a {noun2} to help you complete this mission. Remember, teamwork is essential, so make sure to {verb3} with your fellow {pluralNoun2}. The enemy is known to use {adjective2} {pluralNoun3}, so stay alert and be ready for anything. Once you {adverb1} {verb4} the target, report back to me {adverb2}. Failure is not an option. Good luck!";
            return madLibList;
        }
    }
}