using ECommerce.API.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public async Task<IEnumerable<ApiProduct>> GetAsync()
        {
            return new[] { new ApiProduct { Id = Guid.NewGuid(), Description = "fake" } };
        }

        [HttpPost]
        public async Task PostAsync()
        {

        }
    }
}
