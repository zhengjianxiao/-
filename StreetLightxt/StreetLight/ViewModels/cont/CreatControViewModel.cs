using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StreetLight.ViewModels.cont
{
    public class CreatControViewModel
    {
        [Display(Name = "控制器名称：")]
        [Required(ErrorMessage = "请输入控制器名称")]
        public string Name { get; set; }

        [Display(Name = "控制器状况：")]
        [Required(ErrorMessage = "请输入控制器状况")]
        public string Conwell { get; set; }

        [Display(Name = "生产厂家：")]
        [Required(ErrorMessage = "请输入生产厂家")]
        public string Consour { get; set; }
    }
}
