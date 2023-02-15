using AutoMapper;
using MyProject.Repositories.Entities;
using MyProject.Resources.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace MyProject.Services
{
    public class Mapping:Profile
    {
        public Mapping()
        {            
          
            CreateMap<User,UserDTO>().ReverseMap();
            CreateMap<Child,ChildDTO>().ReverseMap();
            
        }
    }
}
