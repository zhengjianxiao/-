using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StreetLight.ViewModels
{
    public class CreatLightViewModel
    {
       
        [Display(Name = "路灯名：")]
        [Required(ErrorMessage = "请输入路灯名")]
        public string Name { get; set; }

        [Display(Name = "路灯照明情况：")]
        [Required(ErrorMessage = "请输入路灯是否照明")]
        public string Iswork { get; set; }

        [Display(Name = "路灯经度：")]
        [Required(ErrorMessage = "请输入经度")]
        public double Lng { get; set; }

        [Display(Name = "路灯纬度：")]
        [Required(ErrorMessage = "请输入纬度")]
        public double Lat { get; set; }

        [Display(Name = "路灯状况：")]
        [Required(ErrorMessage = "请输入路灯状况")]
        public string Iswell { get; set; }


        public string Images { get; set; }

        [Display(Name = "路灯控制器：")]
        [Required(ErrorMessage = "请输入控制器")]
        public string Control { get; set; }

        [Display(Name = "路灯采集器：")]
        [Required(ErrorMessage = "请输入采集器")]
        public string Celle { get; set; }

        [Display(Name = "路灯传感器：")]
        [Required(ErrorMessage = "请输入传感器")]
        public string Sens { get; set; }
        [Display(Name="路灯图片")]
        public List<IFormFile> Photos { get; set; }

    }
}
