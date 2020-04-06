using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StreetLight.Models
{
    public class DbInitializer
    {
        public static void Seed(AppDbcontext context)
        {
            if (context.Lights.Any())
            {
                return;
            }

            context.AddRange
            (
            );
            context.SaveChanges();
        }
        }
}
