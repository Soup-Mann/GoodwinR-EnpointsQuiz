//Reed Goodwin
//10-26-2022
//Endpoints quiz
//Hardcoded section

using Microsoft.AspNetCore.Mvc;

namespace GoodwinR_EnpointsQuiz.Controllers;

[ApiController]
[Route("[controller]")]
public class HardCodeController : ControllerBase
{
 [HttpGet]
    [Route("dinner")]
    public string dinnerfood(){
        
return $"Hey Reed! You had Pizza for dinner!";
}
[HttpGet]
    [Route("multipli")]
    public int multiply(){
    int gator = 5;
    int fador = 10;
        
return gator * fador;
}



}