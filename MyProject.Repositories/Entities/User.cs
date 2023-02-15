using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyProject.Repositories.Entities
{
    public enum eHMO{macabi=1,clalit,meuchedet}
    public enum eGender { male=1,female}
    public class User
    {
      
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public eGender Gender{ get; set; }
        public eHMO Hmo { get; set; }

      
    }
}
