using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StreetLight.ViewModels.cell
{
    public class CreatCellectViewModel
    {
        [Display(Name = "采集器名称：")]
        [Required(ErrorMessage = "请输入采集器名称")]
        public string Name { get; set; }

        [Display(Name = "采集器状况：")]
        [Required(ErrorMessage = "请输入采集器状况")]
        public string Cellectwell { get; set; }

        [Display(Name = "生产厂家：")]
        [Required(ErrorMessage = "请输入生产厂家")]
        public string Cellectsour { get; set; }
    }
}
