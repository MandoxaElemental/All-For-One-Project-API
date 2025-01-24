using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using All_For_One_Project_API.Services;
using Microsoft.AspNetCore.Mvc;

namespace All_For_One_Project_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RestaurantPickerController : ControllerBase
    {
        private readonly RestaurantPickerServices _restauruantPickerServices;
        public RestaurantPickerController(RestaurantPickerServices restaurantPickerServices){
            _restauruantPickerServices = restaurantPickerServices;
        }

        [HttpGet]
        [Route("RestaurantPicker/{yourChoice}")]
        public string RestauruntPickerOutput(string yourChoice){
            return _restauruantPickerServices.yourFood(yourChoice);
        }
    }
}