using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WTProgammingTest.Models;

namespace WTProgammingTest.Service
{
    public class MainObjectRepository : IMainObjectRepository
    {
        private readonly List<MainObject> _objectList;

        public MainObjectRepository()
        {
            var objectList = new List<MainObject>();

            try
            {
                //retrieving and parsing into json array from data.json & data2.json files

                JArray dataFile = JArray.Parse(System.IO.File.ReadAllText(@"Data\data.json"));

                JArray data2File = JArray.Parse(System.IO.File.ReadAllText(@"Data\data2.json"));

                dataFile.Merge(data2File);


                //variable DataFile contains merged data, deserialze and cast to MainObject

                for (int i = 0; i <= dataFile.Count - 1; i++)
                {
                    objectList.Add(JsonConvert.DeserializeObject<MainObject>(dataFile[i].ToString()));
                }

                this._objectList = objectList;
            }
            catch (Exception ex)
            {

                throw new Exception("Error in processing JSON file, " + ex.Message);
            }
             
        }

        public List<MainObject> SortByLocation()
        {
            var model = _objectList;
            CustomSort.SortListByLocation(model);

            //var model = _objectList.OrderBy(obj => obj.Data.Min(loc => loc.Location)).ToList();
            
            return model;
        }

        public List<MainObject> SortByValue()
        {
            var model = _objectList;
            CustomSort.SortListByValue(model);

            //  var model = _objectList.OrderBy(obj => obj.Data.Min(loc => loc.Value)).ToList();
            
            return model;
        }
    }
}
