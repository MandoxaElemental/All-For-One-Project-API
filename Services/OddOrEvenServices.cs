using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace All_For_One_Project_API.Services
{
    public class OddOrEvenServices
    {
         public string result = "";
            bool validCheck = false;
            int convertedNum;
        public string EvenOrOdd(string num){
            validCheck = int.TryParse(num, out convertedNum);
            if(validCheck == false){
                result = "C'mon mate... Give me a bloomin' Numbah'";
                return result;
            }
            else{
            if((convertedNum % 2) == 0){
                result = $"{num}... That would be an Even Numbah' mate...";
            } else {
                result = $"{num}... That's an Odd Numbah' mate...";
            }
            }
            return result;
        }
    }
}