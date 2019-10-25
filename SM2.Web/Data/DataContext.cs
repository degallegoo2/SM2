using Microsoft.EntityFrameworkCore;
using SM2.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SM2.Web.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Cesantia> Cesantias { get; set; }

        public DbSet<City> Cities { get; set; }

        public DbSet<Disability> Disabilities { get; set; }

        public DbSet<License> Licenses { get; set; }

        public DbSet<Loan> Loans { get; set; }

        public DbSet<Rep> Reps { get; set; }

        public DbSet<Transfer> Transfers { get; set; }

        public DbSet<TypeCesantia> TypeCesantias { get; set; }

        public DbSet<TypeDisability> TypeDisabilities { get; set; }

        public DbSet<TypeLicense> TypeLicenses { get; set; }

        public DbSet<TypeLoan> TypeLoans { get; set; }


    }
}
