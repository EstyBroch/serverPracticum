using MyProject.Repositories.Entities;
using System;

namespace MyProject.WebAPI.Models
{
    //public enum eHMOModel { macabi, clalit, meuchedet }
    //public enum eGender { male=1,female}
    public class UserModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string IdNumber { get; set; }
        public eGender Gender { get; set; }
        public eHMO Hmo { get; set; }
    }
}
