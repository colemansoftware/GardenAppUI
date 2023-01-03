using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class PlantsData : IPlantsData
    {
        private readonly ISqlDataAccess _db;

        public PlantsData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<PlantModel>> GetPlants()
        {
            string sql = "select * from dbo.plants";

            return _db.LoadData<PlantModel, dynamic>(sql, new { });
            
        }

        public Task InsertPlant(PlantModel plant)
        {
            string sql = @"insert into dbo.plants (plantName, plantDescription, sunlightTime, species, watering_schedule, fertilizing_schedule)
                           values (@PlantName, @PlantDescription, @SunlightTime, @Species, @Watering_schedule, @Fertilizing_schedule);";

            return _db.SaveData(sql, plant);
        }
    }
}
