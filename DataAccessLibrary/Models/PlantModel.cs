using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.Models
{
    public class PlantModel
    {
        public string plant_id { get; set; }
        public string PlantName { get; set; }
        public string PlantDescription { get; set; }
        public string SunlightTime { get; set; }
        public string species { get; set; }
        public string watering_schedule { get; set; }
        public string fertilizing_schedule { get; set; }
    }
}
