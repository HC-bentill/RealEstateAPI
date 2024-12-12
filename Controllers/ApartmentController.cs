using Microsoft.AspNetCore.Mvc;

namespace RealEstateAPI.Controllers;


[ApiController]
[Route("[controller]")]
public class ApartmentController : Controller
{
   public ApartmentController()
   {
   
   }

   [HttpGet("Testing")]
   public string[] Testing()
   {
      string[] response = new[] { "Henry", "Bentil"};

      return response;
   }

}