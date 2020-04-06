using StreetLight.Models.sensed;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StreetLight.ViewModels.sened
{
    public class CreatSensorViewModel
    {
        [Display(Name = "传感器名称：")]
        [Required(ErrorMessage = "请输入传感器名称")]
        public string Name { get; set; }

        [Display(Name = "传感器状况：")]
        [Required(ErrorMessage = "请输入传感器状况")]
        public string Senwell { get; set; }

        [Display(Name = "生产厂家：")]
        [Required(ErrorMessage = "请输入生产厂家")]
        public string Sensour { get; set; }
    }
}
