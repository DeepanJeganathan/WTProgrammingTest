using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WTProgammingTest.Models;

namespace WTProgammingTest.Service
{
    public interface IMainObjectRepository
    {
        List<MainObject> SortByLocation();
        List<MainObject> SortByValue();

    }
}
