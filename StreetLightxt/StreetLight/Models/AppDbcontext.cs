using Microsoft.EntityFrameworkCore;
using StreetLight.Models.celled;
using StreetLight.Models.controled;
using StreetLight.Models.sensed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace StreetLight.Models
{
    public class AppDbcontext:IdentityDbContext<IdentityUser>
    {
        public AppDbcontext(DbContextOptions<AppDbcontext> options) : base(options)
        {


        }
        public DbSet<Light> Lights { get; set; }
       
        public DbSet<Cellect> Cellects { get; set; }
        public DbSet<ConVector> ConVectors { get; set; }
        public DbSet<Sensor> Sensors { get; set; }
    }
}
