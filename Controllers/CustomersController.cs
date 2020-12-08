using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreSwaggerDemo.ViewModels;

namespace AspNetCoreSwaggerDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var list = new List<CustomerViewModel>
            {
                new CustomerViewModel {Id = 1, FirstName = "Ramesh", LastName = "SR", Email = "ramesh@domain.com", DateOfBirth = new DateTime(1990, 1, 1)},
                new CustomerViewModel {Id = 2, FirstName = "Vishal", LastName = "Kumar", Email = "vishal@domain.com", DateOfBirth = new DateTime(1987, 5, 1)},
                new CustomerViewModel {Id = 3, FirstName = "Kishor", LastName = "Vaidya", Email = "kishore@domain.com", DateOfBirth = new DateTime(1989, 4, 30)},
            };

            return Ok(list);
        }

        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {

            return Ok(
                new CustomerViewModel
                {
                    Id = 1, FirstName = "Ramesh", LastName = "SR", Email = "ramesh@domain.com",
                    DateOfBirth = new DateTime(1990, 1, 1)
                }
            );
        }

        [HttpPost]
        public IActionResult Create([FromBody] CustomerViewModel viewModel)
        {
            return Ok();
        }

        [HttpPut("{id:int}")]
        public IActionResult Update(int id, [FromBody] CustomerViewModel viewModel)
        {
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }
    }
}
