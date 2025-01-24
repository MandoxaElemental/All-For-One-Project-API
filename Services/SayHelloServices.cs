using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace All_For_One_Project_API.Services
{
    public class SayHelloServices
    {
        public string result = "";
        bool validCheck = false;
        int convertedNum;
        public string AddNameToList(string name){
            validCheck = int.TryParse(name, out convertedNum);
            if (validCheck == true){
                result = "Hey, are ya listenin'? I'm asking for your name punk...";
            }
            else{    
            result = $"So you're {name}? Welcome to da club pal!";
            }
            return result;
        }
    }
}