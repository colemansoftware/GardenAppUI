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
        [StringLength(50, ErrorMessage = "Plant Name is too long.")]
        [MinLength(3, ErrorMessage = "Plant Name is too short.")]
        public string PlantName { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Plant Description is too long.")]
        [MinLength(3, ErrorMessage = "Plant Description is too short.")]
        public string PlantDescription { get; set; }

        [Required]
        [StringLength(25, ErrorMessage = "Plant Sunlight is too long.")]
        [MinLength(1, ErrorMessage = "Plant sunlight is too short.")]
        public string SunlightTime { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "species Name is too long.")]
        [MinLength(3, ErrorMessage = "species Name is too short.")]
        public string species { get; set; }

        [Required]
        [StringLength(250, ErrorMessage = "watering_schedule is too long.")]
        [MinLength(3, ErrorMessage = "watering_schedule is too short.")]
        public string watering_schedule { get; set; }

        [Required]
        [StringLength(250, ErrorMessage = "fertilizing_schedule is too long.")]
        [MinLength(3, ErrorMessage = "fertilizing_schedule is too short.")]
        public string fertilizing_schedule { get; set; }
    }
}
