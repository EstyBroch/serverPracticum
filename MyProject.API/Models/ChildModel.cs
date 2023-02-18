using MyProject.Repositories.Entities;
using System;

namespace MyProject.WebAPI.Models
{
    public class ChildModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string IdNumber { get; set; }
        public int? IdFather { get; set; }
        public int? IdMother { get; set; }
      
    }
}
