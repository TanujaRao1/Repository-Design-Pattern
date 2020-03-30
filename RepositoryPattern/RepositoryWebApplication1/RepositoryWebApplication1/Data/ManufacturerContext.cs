using Microsoft.EntityFrameworkCore;
using RepositoryWebApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryWebApplication1.Data
{
    public class ManufacturerContext : DbContext
    {
        public ManufacturerContext(DbContextOptions<ManufacturerContext> options) : base(options)
        {

        }

        public DbSet<Manufacturer> Manufacturer { get; set; }
    }
}
