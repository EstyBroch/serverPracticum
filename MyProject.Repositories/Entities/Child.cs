using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Entities
{
    public class Child
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string IdNumber { get; set; }
        [ForeignKey ("Father")]
        public int? IdFather { get; set; }
        public User? Father { get; set; }
        [ForeignKey ("Mother")]///do not show all the object

        public int? IdMother { get; set; }
        public User? Mother { get; set; }
    }
}
