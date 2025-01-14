using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RealEstateAPI.data;
using RealEstateAPI.Dtos;
using RealEstateAPI.Models;
using AutoMapper;

namespace RealEstateAPI.Controllers;


[ApiController]
[Route("[controller]")]
public class ApartmentController : ControllerBase
{
   private readonly DataContextEF _entityFramework;
   private readonly IMapper _mapper;
   public ApartmentController(IConfiguration config)
    {
        _entityFramework = new DataContextEF(config);
        _mapper = new Mapper(new MapperConfiguration(cfg =>{
            cfg.CreateMap<ApartmentDTO, Apartment>();
        }));
    }

   [HttpPost("[action]")]
   public async Task<ApiResponse> AddApartment([FromBody] ApartmentDTO payload)
   {
      if (payload == null)
      {
         return new ApiResponse
         {
            Success = false,
            Message = "Payload is null"
         };
      }

      try
      {
          Apartment apartmentDB = _mapper.Map<Apartment>(payload);
         _entityFramework.Add(apartmentDB);
         int rowsAffected = await _entityFramework.SaveChangesAsync();
         if (rowsAffected > 0)
         {
            return new ApiResponse
            {
                  Success = true,
                  Message = "Apartment added successfully",
            };
         } 

        throw new Exception("Failed to Add User");
      }
      catch (DbUpdateException dbEx)
      {
         return new ApiResponse
         {
               Success = false,
               Message = $"Database error occurred while adding the apartment: {dbEx.Message}",
         };
      }
      catch (Exception ex)
      {
         
         return new ApiResponse
            {
               Success = false,
               Message = $"An unexpected error occurred: {ex.Message}",
            };
      }
   }

}