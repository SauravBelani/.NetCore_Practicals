using AutoMapper;
using Practical_17.Models;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace Practical_17.Configuration
{
    public class MapperConfig:Profile
    {
        public MapperConfig()
        {
            CreateMap<Student, StudentVM>().ReverseMap();
        }
    }
}