using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BarberShopMVC.Models;

namespace BarberShopMVC.Data
{
    public class BarberShopMVCContext : DbContext
    {
        public BarberShopMVCContext (DbContextOptions<BarberShopMVCContext> options)
            : base(options)
        {
        }

        public DbSet<BarberShopMVC.Models.Barber> Barber { get; set; } = default!;
    }
}
