using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace All_For_One_Project_API.Services
{
    public class AskingQuestionsServices
    {
        public string result = "";
        bool validCheck = false;
        int convertedNum;
        bool validCheck2 = false;
        int convertedNum2;
        public string FinalQuestion(string name, string time){
            validCheck = int.TryParse(name, out convertedNum);
            validCheck2 = int.TryParse(time, out convertedNum2);
            if(validCheck == true || validCheck2 == false)
            {
                result = "Ze info that you have provided iz not relevant...";
                return result;
            }
            else if (convertedNum2 > 12 || convertedNum2 == 0)
            {
                result = "Pleaze give me an hour between 1-12";
            }
            else
            {
                result = $"Vell than {name} mein friend! I vill be seeing you at {time}:00. Don't be late";
            }
            return result;
            }
            
        }
    }
