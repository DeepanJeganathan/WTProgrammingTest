using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WTProgammingTest.Models;
using WTProgammingTest.Service;
using WTProgammingTest.ViewModels;

namespace WTProgammingTest.Controllers
{
    public class HomeController : Controller
    {

        private readonly IMainObjectRepository _mainObjectRepository;
        private readonly IMapper _mapper;


        public HomeController(IMainObjectRepository mainObjectRepository,IMapper mapper)
        {

            this._mainObjectRepository = mainObjectRepository;
            this._mapper = mapper;
        
        }
        

        public  ActionResult Index()
        {          
           
            return View();
        
        }


        public ActionResult<List<MainObjectViewModel>> Sorted( string sortBy)
        {

            //using automapper to map domain model to view model
            if (sortBy=="Location")
            {               
                var Objects = _mapper.Map<IEnumerable<MainObject>, IEnumerable<MainObjectViewModel>>(_mainObjectRepository.SortByLocation());
                ViewData["Heading"] = "By Location";
                return View(Objects);
            }
            else if (sortBy=="Value")
            {                
                var Objects = _mapper.Map<IEnumerable<MainObject>, IEnumerable<MainObjectViewModel>>(_mainObjectRepository.SortByValue());
                ViewData["Heading"] = "By Value";
                return View(Objects);           }                     

               return View(nameof(Index));       
            
        }
                 
       
        public IActionResult Error()
        {
         
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });       
            
        }
    }
}
