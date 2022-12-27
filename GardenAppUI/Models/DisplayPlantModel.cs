using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GardenAppUI.Models
{
    public class DisplayPlantModel
    {
        [Required]
        [StringLength(15, ErrorMessage = "Plant Name is too long.")]
        [MinLength(5, ErrorMessage = "Plant Name is too short.")]
        public string PlantName { get; set; }

        [Required]
        [StringLength(15, ErrorMessage = "Plant Description is too long.")]
        [MinLength(5, ErrorMessage = "Plant Description is too short.")]
        public string PlantDescription { get; set; }

        [Required]
        [StringLength(15, ErrorMessage = "Plant Sunlight is too long.")]
        [MinLength(1, ErrorMessage = "Plant sunlight is too short.")]
        public string SunlightTime { get; set; }
    }
}
