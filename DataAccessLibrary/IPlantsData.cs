using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public interface IPlantsData
    {
        Task<List<PlantModel>> GetPlants();
        Task InsertPlant(PlantModel plant);
    }
}