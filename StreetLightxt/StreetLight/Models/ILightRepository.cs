using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StreetLight.Models
{
 public    interface ILightRepository
    {
        IEnumerable<Light> GetAllLights();
        Light GetLightById(int id);
        void AddLight(Light light);
        Light Update(Light updatelight);
        Light Delete(int id);
      
       
    }
}
