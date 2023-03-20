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
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<IEnumerable<UserDTO>> Get()
        {
            return await _userService.GetAllAsync();
        }

        [HttpGet("getById{id}")]
        public async Task<UserDTO> Get(int id)
        {
            return await _userService.GetByIdAsync(id);
        }

        [HttpGet("{idNumber}")]
        public async Task<UserDTO> Get(string idNumber)
        {
            return await _userService.GetByIdNumberAsync(idNumber);
        }

        [HttpPost]//add
        public async Task<UserDTO> Post([FromBody] UserModel model)
        {
            return await _userService.AddAsync(new UserDTO() {FirstName=model.FirstName,LastName=model.LastName,IdNumber=model.IdNumber
            ,DateOfBirth=model.DateOfBirth,Gender=(eGenderDTO) model.Gender,Hmo=(eHMODTO)model.Hmo});
        }

        [HttpPut("{id}")]//update
        public async Task<UserDTO> Put(int id, [FromBody] UserModel model)
        {
            UserDTO user = new UserDTO() {
                Id = id,
                FirstName = model.FirstName,
                LastName = model.LastName,
                IdNumber = model.IdNumber,
                DateOfBirth = model.DateOfBirth,
                Gender = (eGenderDTO)model.Gender,
                Hmo = (eHMODTO)model.Hmo
            };
            return await _userService.UpdateAsync(user);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _userService.DeleteAsync(id);
        }
    }
}
