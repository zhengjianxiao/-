using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StreetLight.Models.controled
{
    public class ConVectorRepository:IConVectorRepository
    {
        private readonly AppDbcontext _context;
        public ConVectorRepository(AppDbcontext appDbcontext)
        {

            _context = appDbcontext;

        }

        public void Addcontro(ConVector conVector)
        {
            _context.ConVectors.Add(conVector);
            _context.SaveChanges();

        }

        public ConVector Delete(int id)
        {
            ConVector conVector = _context.ConVectors.FirstOrDefault(n => n.Id == id);
            if (conVector != null)
            {

                _context.ConVectors.Remove(conVector);
            }
            _context.SaveChanges();
            return conVector;
        }

        public IEnumerable<ConVector> GetAllConVectors()
        {
            return _context.ConVectors;

        }

        public ConVector GetConVectorById(int id)
        {
            return _context.ConVectors.FirstOrDefault(n => n.Id == id);
        }
    }
}
