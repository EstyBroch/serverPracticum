using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyProject.Resources.DTOs;
using MyProject.Services.Interfaces;
using MyProject.WebAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChildrenController : ControllerBase
    {

        private readonly IChildService _childService;

        public ChildrenController(IChildService childService)
        {
            _childService = childService;
        }

        [HttpGet]
        public async Task<IEnumerable<ChildDTO>> Get()
        {
            return await _childService.GetAllAsync();
        }

       
        [HttpGet("{idNumber}")]
        public async Task<ChildDTO> Get(string idNumber)
        {
            return await _childService.GetByIdNumberAsync(idNumber);
        }

        [HttpPost]
        public async Task<ChildDTO> Post([FromBody] ChildModel model)
        {
            return await _childService.AddAsync(new ChildDTO() { Name = model.Name, DateOfBirth = model.DateOfBirth,IdNumber=model.IdNumber
            ,IdFather= model.IdFather,IdMother= model.IdMother});
        }

        [HttpPut("{id}")]
        public async Task<ChildDTO> Put(int id, [FromBody] ChildModel model)
        {
            ChildDTO r = new ChildDTO() { Id = id, Name = model.Name,
                DateOfBirth = model.DateOfBirth,
                IdNumber = model.IdNumber,
                IdFather = model.IdFather,
                IdMother =model.IdMother
            };
            return await _childService.UpdateAsync(r);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _childService.DeleteAsync(id);
        }
    }
}
