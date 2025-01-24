using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace All_For_One_Project_API.Services
{
    public class GreaterThanServices
    {
        public string comparisonList = "";
        public string comparisonList2 = "";
        bool validCheck1 = false;
        int convertedNum1;
        bool validCheck2 = false;
        int convertedNum2;
        public string UpdateComparison(string firstNum, string secondNum){
            validCheck1 = int.TryParse(firstNum, out convertedNum1);
            validCheck2 = int.TryParse(secondNum, out convertedNum2);
            
            if (validCheck1 == false || validCheck2 == false)
            {
                comparisonList = "Listen little baby man, give Heavy two numbers to compare...";
            }
            else
            {
            if (convertedNum1 > convertedNum2){
                comparisonList = $"{firstNum} is Greater than {secondNum}";
                comparisonList2 = $"{secondNum} is Less than {firstNum}";
            } else if (convertedNum1 < convertedNum2){
                comparisonList = $"{firstNum} is Less than {secondNum}";
                comparisonList2 = $"{secondNum} is Greater than {firstNum}";
            } else {
                comparisonList = $"{firstNum} is Equal to {secondNum}";
                comparisonList2 = $"And I will repeat myself once again: {secondNum} is Equal to {firstNum}";
            }
            }
            
            return comparisonList + "; " + comparisonList2;
        }
    }
}