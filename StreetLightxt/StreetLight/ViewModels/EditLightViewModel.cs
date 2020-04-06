using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StreetLight.ViewModels
{
    public class EditLightViewModel:CreatLightViewModel
    {
        public int Id { get; set; }
        public string ExistingPhotoPath { get; set; }
    }
}
