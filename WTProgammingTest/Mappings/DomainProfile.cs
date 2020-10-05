using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WTProgammingTest.Models;
using WTProgammingTest.ViewModels;

namespace WTProgammingTest.Mappings
{
    public class DomainProfile:Profile
    {
        //add model mapping config here  
        public DomainProfile()
        {
            CreateMap<MainObject, MainObjectViewModel>();
        }
    }
}
