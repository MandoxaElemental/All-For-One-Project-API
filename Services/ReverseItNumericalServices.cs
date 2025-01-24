using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace All_For_One_Project_API.Services
{
    public class ReverseItNumericalServices
    {
         public string reversedNum = "";
        bool validCheck = false;
        int convertedNum;
        string emptyNum = string.Empty;
        public string ReversedNum(string userInput){
            validCheck = int.TryParse(userInput, out convertedNum);
            if (userInput.Length > 10){
                reversedNum = "That's a little too much numbers partner. Give me at least 10 at a time...";
                return reversedNum;
            } else if(validCheck == false){
                reversedNum = "Hold up Partner, I only asked for numbers...";
                return reversedNum;
            }
            else{
            for(int i=userInput.Length-1; i >= 0; i--){
                emptyNum += userInput[i];
            }
            }
            reversedNum = $"Let me see... {userInput}. So that would be: {emptyNum}. Thanks for your help parnter.";
            return reversedNum;
        }
    }
}