using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace All_For_One_Project_API.Services
{
    public class RestaurantPickerServices
    {
        public string resultList = "";
    Random rng = new Random();

    string [] french = {
        "Robuchon au Dôme",
        "Arpège",
        "Per Se",
        "The French Laundry",
        "Mirazur",
        "L'Effervescence",
        "Noma",
        "Asador Etxebarri",
        "Septime",
        "Pavillon"

    };
    string[] burgers = { "In-n-Out", "McDonalds", "Burger King", "Five Guys", "The Habit", "Jack in the Box", "Wendys", "Red Robin", "Chilli's", "Whataburger"};
    string[] tacos = { "Taco Bell", "Del Taco", "Rubios", "Chipotle", "El Pollo Loco", "Café Rio", "Baja Fresh", "Qdoba", "On the Border Mexican Grill & Cantina", "Taco John's"};
    string[] chicken = { "Chick-fil-A", "Raising Canes", "Wing Stop", "PopeYES", "KFC", "Church's Texas Chicken", "Buffalo Wild Wings", "Zaxby's", "Jollibee's", "Bonchon"};
    string[] pizza = { "Pizza Hut", "Round Table", "Domino's", "Little Caesars", "Mountain Mike's", "Pizza Guys", "Shakey's Pizza", "CiCis Pizza", "MOD Pizza", "Papa Murphy’s"};
    string[] other = { "Panda Express", "Sonic", "Dunkin Donuts", "Dairy Queen", "Arby's", "Papa Johns", "Jersey Mike's", "Firehouse Subs", "Panera Bread", "Subway" };
    public string yourFood(string yourChoice)
        {
            
            int ourRandomNumber = rng.Next(other.Length);
            string foodChoice = yourChoice.ToUpper();
            switch (foodChoice)
            {
                case "FRENCH":
                resultList = french[ourRandomNumber];
                break;

                case "BURGER":
                resultList = burgers[ourRandomNumber];
                break;
                
                case "TACOS":
                resultList = tacos[ourRandomNumber];
                break;

                case "CHICKEN":
                resultList = chicken[ourRandomNumber];
                break;

                case "PIZZA":
                resultList = pizza[ourRandomNumber];
                break;

                case "OTHER":
                resultList = other[ourRandomNumber];
                break;

                default:
                resultList = "Please do not waste my time...";
                break;
            }
            return resultList;
        }
    }
}