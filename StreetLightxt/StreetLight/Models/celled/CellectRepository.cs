using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StreetLight.Models.celled
{
    public class CellectRepository:ICellectRepository
    {
        private readonly AppDbcontext _context;
        public CellectRepository(AppDbcontext appDbcontext)
        {

            _context = appDbcontext;

        }

        public void Addcellect(Cellect cellect)
        {
            _context.Cellects.Add(cellect);
            _context.SaveChanges();
        }

        public Cellect Delete(int id)
        {
            Cellect cellect = _context.Cellects.FirstOrDefault(n => n.Id == id);
            if (cellect != null)
            {

                _context.Cellects.Remove(cellect);
            }
            _context.SaveChanges();
            return cellect;
        }

        public IEnumerable<Cellect> GetAllCellects()
        {
            return _context.Cellects;
        }

        public Cellect GetCellectById(int id)
        {
            return _context.Cellects.FirstOrDefault(n => n.Id == id);
        }
    }
}
