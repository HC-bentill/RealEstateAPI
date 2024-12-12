using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore

namespace RealEstateAPI.data
{   
    public class DataContextEF : DbContext 
    {
        private readonly IConfiguration _config

        public DataContextEF(IConfiguration config)
        {
            _config = config;
        }
    }
}