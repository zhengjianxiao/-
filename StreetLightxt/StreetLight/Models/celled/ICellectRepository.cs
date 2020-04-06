using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StreetLight.Models.celled
{
   public interface ICellectRepository
    {
        IEnumerable<Cellect> GetAllCellects();
        Cellect GetCellectById(int id);

        void Addcellect(Cellect cellect);
       
        Cellect Delete(int id);
    }
}
