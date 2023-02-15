using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Resources.DTOs
{
    public class ChildDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string IdNumber { get; set; }
        public int? IdFather { get; set; }
        public UserDTO? Father { get; set; }
        public int? IdMother { get; set; }
        public UserDTO? Mother { get; set; }
    }
}
