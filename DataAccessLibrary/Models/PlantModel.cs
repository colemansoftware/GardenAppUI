using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.Models
{
    public class PlantModel
    {
        public string Plant_id { get; set; }
        public string PlantName { get; set; }
        public string PlantDescription { get; set; }
        public string SunlightTime { get; set; }
        public string Species { get; set; }
        public string Watering_schedule { get; set; }
        public string Fertilizing_schedule { get; set; }
    }
}
