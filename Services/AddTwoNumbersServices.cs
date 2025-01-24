using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace All_For_One_Project_API.Services
{
    public class AddTwoNumbersServices
    {
        public string numbers = "";
        bool validCheck1 = false;
        int convertedNum1;
        bool validCheck2 = false;
        int convertedNum2;
        public string AddNumbers(string numberOne, string numberTwo)
        {
            validCheck1 = int.TryParse(numberOne, out convertedNum1);
            validCheck2 = int.TryParse(numberTwo, out convertedNum2);
            if (validCheck1 == false || validCheck2 == false)
            {
                numbers = "Listen Maggot, when I ask you for a number, you will give me a number...";
                return numbers;
            }
            else
            {
                numbers = $"Lemme see... {numberOne} plus {numberTwo} is equal to: {convertedNum1 + convertedNum2}. See, I know math...";
                return numbers;
            }
        }
    }
}