//Reed Goodwin
//10-26-2022
//Endpoints quiz
//Input Section

using Microsoft.AspNetCore.Mvc;

namespace GoodwinR_EnpointsQuiz.Controllers;

[ApiController]
[Route("[controller]")]
public class InputController : ControllerBase
{
 [HttpGet]
    [Route("urmother/{number1}/{number2}")]
    public int multiplies(string number1, string number2){
    int convertNum1 = Convert.ToInt32(number1);
    int convertNum2 = Convert.ToInt32(number2);
    return convertNum1 * convertNum2;

}

[HttpGet]
    [Route("dinner/{name}/{food}")]
    public string dinnerfood(string name, string food){
        
return $"whats up {name}! You had {food} for dinner!";
}
}