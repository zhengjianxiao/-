using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StreetLight.Models.controled
{
   public interface IConVectorRepository
    {
        IEnumerable<ConVector> GetAllConVectors();
        ConVector GetConVectorById(int id);
        void Addcontro(ConVector conVector);

        ConVector Delete(int id);
    }
}
