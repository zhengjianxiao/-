using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StreetLight.Models.sensed
{
   public interface ISensorRepository
    {
        IEnumerable<Sensor> GetAllSensors();
        Sensor GetSensorById(int id);
        void Addsensor(Sensor sensor);

        Sensor Delete(int id);
    }
}
