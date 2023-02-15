using MyProject.Repositories.Entities;
using MyProject.Resources.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services.Interfaces
{
    public interface IChildService
    {
        Task<List<ChildDTO>> GetAllAsync();
        Task<ChildDTO> GetByIdAsync(int id);
        Task<ChildDTO> GetByIdNumberAsync(string idNumber);
        Task<ChildDTO> AddAsync(ChildDTO childDTO);
        Task<ChildDTO> UpdateAsync(ChildDTO childDTO);
        Task DeleteAsync(int id);
    }
}
