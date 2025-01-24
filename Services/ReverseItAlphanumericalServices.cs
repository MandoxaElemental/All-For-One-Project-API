using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace All_For_One_Project_API.Services
{
    public class ReverseItAlphanumericalServices
    {
        public string reversedWord = "";
        string emptyWord = string.Empty;
        public string ReversedString(string userInput){
            for(int i=userInput.Length-1; i >= 0; i--){
                emptyWord += userInput[i];
            }
            reversedWord = $"Huh... {emptyWord}?... Ohhhh, you mean {userInput}... *burp*";
            return reversedWord;
        }
    }
}