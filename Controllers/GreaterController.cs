//Reed Goodwin
//10-25-2022
//Greater or lessThan
//This program will take 2 inputs and see which one is greater or less than
//Peer Review:Marcel R. The program ran well. Took 2 inputs, converted them into ints, and compared values to output which one was greater or if they were equal. Solid code and work! :D


using Microsoft.AspNetCore.Mvc;

namespace GoodwinR_GreaterOrLess.Controllers;

[ApiController]
[Route("[controller]")]
public class GreaterLessController : ControllerBase
{
    [HttpGet]
    [Route("urmother/{number1}/{number2}")]
    public string Gayball(string number1, string number2){
    int convertNum1 = Convert.ToInt32(number1);
    int convertNum2 = Convert.ToInt32(number2);

 if(convertNum1 > convertNum2){
    return $"{number1} is greater than {number2}";
 }else if(convertNum1 == convertNum2){
return $"{number1} is equal too {number2}";
 }else if(convertNum1 < convertNum2){
    return $"{number1} is less than {number2}";
 }else{
    return "Invalid entry";
 }
    //return convertNum1 + convertNum2;

}
}
