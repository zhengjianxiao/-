using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StreetLight.Models.sensed
{
    public class SensorRepository:ISensorRepository
    {
        private readonly AppDbcontext _context;
        public SensorRepository(AppDbcontext appDbcontext)
        {

            _context = appDbcontext;

        }

        public void Addsensor(Sensor sensor)
        {
            _context.Sensors.Add(sensor);
            _context.SaveChanges();
        }

        public Sensor Delete(int id)
        {
            Sensor sensor = _context.Sensors.FirstOrDefault(n => n.Id == id);
            if (sensor != null)
            {

                _context.Sensors.Remove(sensor);
            }
            _context.SaveChanges();
            return sensor;
        }

        public IEnumerable<Sensor> GetAllSensors()
        {
            return _context.Sensors;
        }

        public Sensor GetSensorById(int id)
        {
            return _context.Sensors.FirstOrDefault(n => n.Id == id);
        }
    }
}
