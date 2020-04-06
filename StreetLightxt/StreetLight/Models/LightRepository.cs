using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StreetLight.Models
{
    public class LightRepository : ILightRepository
    {
        private readonly AppDbcontext _context;
        public LightRepository(AppDbcontext appDbcontext)
        {

            _context = appDbcontext;

        }

        public void AddLight(Light light)
        {
          
            _context.Lights.Add(light);
            _context.SaveChanges();
        }




       

        public IEnumerable<Light> GetAllLights()
        {
            return _context.Lights;
        }

        public Light GetLightById(int id)
        {
            return _context.Lights.FirstOrDefault(n => n.Id == id);
        }

       
        public Light Delete(int id)
        {
            Light light = _context.Lights.FirstOrDefault(n => n.Id == id);
            if (light != null)
            {

                _context.Lights.Remove(light);
            }
            _context.SaveChanges();
            return light;
        }

        public Light Update(Light updatelight)
        {
            var light = _context.Lights.Attach(updatelight);

            light.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return updatelight;
        }

        
    }
}
