using SM2.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SM2.Web.Data
{
    public class SeedDB
    {
        private readonly DataContext _context;

        public SeedDB(DataContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();

            await CheckRepsAsync();
            await CheckTypeCesantiaAsync();
            await CheckCityAsync();
            await CheckTypeDisabilityAsync();
            await CheckTypeLicenseAsync();
            await CheckTypeLoanAsync();
            await CheckType_request();
            await CheckStatusAsync();
        }

        

        private async Task CheckRepsAsync()
        {
            if(!_context.Reps.Any())
            {
               // await _context.Reps.Add(new Rep { rep_id = 123456, nombre = "Daniel Gallego", email = "correo@correo.com", activo = 1, tipo = 1, pais = 1,  cedula = 123456,  empresa = 1  });
            }
        }

        private async Task CheckTypeCesantiaAsync()
        {
            if(!_context.TypeCesantias.Any())
            {
                _context.TypeCesantias.Add(new TypeCesantia { name = "Empresa" });
                _context.TypeCesantias.Add(new TypeCesantia { name = "Fondo" });
                _context.TypeCesantias.Add(new TypeCesantia { name = "Empresa y Fondo" });
                await _context.SaveChangesAsync();
            }
        }
        private async Task CheckCityAsync()
        {
            if(!_context.Cities.Any())
            {
                _context.Cities.Add(new City {nameCity  = "Medellín" });
                _context.Cities.Add(new City { nameCity = "Bogotá" });
                _context.Cities.Add(new City { nameCity = "Manizales" });
                _context.Cities.Add(new City { nameCity = "Cartagena" });
                _context.Cities.Add(new City { nameCity = "Bucaramanga" });
                _context.Cities.Add(new City { nameCity = "Barranquilla" });
                _context.Cities.Add(new City { nameCity = "Cali" });
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckTypeDisabilityAsync()
        {
            if(!_context.TypeDisabilities.Any())
            {
                _context.TypeDisabilities.Add(new TypeDisability {name = "Enfermedad general / Prorroga" });
                _context.TypeDisabilities.Add(new TypeDisability { name = "Accidente de trabajo / Prorroga" });
                _context.TypeDisabilities.Add(new TypeDisability { name = "Licencia de Maternidad" });
                _context.TypeDisabilities.Add(new TypeDisability { name = "Licencia de Paternidad" });
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckTypeLicenseAsync()
        {
            if (!_context.TypeLicenses.Any()) 
            {
                _context.TypeLicenses.Add(new TypeLicense { name = "Licencia Remunerada" });
                _context.TypeLicenses.Add(new TypeLicense { name = "Licencia No Remunerada" });
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckTypeLoanAsync()
        {
           if(!_context.TypeLoans.Any())
            {
                _context.TypeLoans.Add(new TypeLoan { Name = "Prestamo de vivienta"});
                _context.TypeLoans.Add(new TypeLoan { Name = "Prestamo de Vehiculo" });
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckType_request()
        {
            if(!_context.Type_Requests.Any())
            {
                _context.Type_Requests.Add(new Type_Request { Id = 1, Nombre = "Cesantías" });
                _context.Type_Requests.Add(new Type_Request { Id = 1, Nombre = "Transfers" });
                _context.Type_Requests.Add(new Type_Request { Id = 1, Nombre = "Disabilities" });
                _context.Type_Requests.Add(new Type_Request { Id = 1, Nombre = "Licenses" });
                _context.Type_Requests.Add(new Type_Request { Id = 1, Nombre = "Loans" });
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckStatusAsync()
        {
            if(!_context.States.Any())
            {
                _context.States.Add(new State { Id = 1, Nomnbre = "Registrado" });
                _context.States.Add(new State { Id = 2, Nomnbre = "En Gestión" });
                _context.States.Add(new State { Id = 3, Nomnbre = "No Aprobado" });
                _context.States.Add(new State { Id = 4, Nomnbre = "Tramitado" });
                await _context.SaveChangesAsync();
            }
        }


        private void AddRep(int rep_id, string nombre, string email, int activo, int tipo, int pais, int cedula, int empresa)
        {
            _context.Reps.Add(new Rep
            {
                rep_id = rep_id,
                nombre = nombre,
                email = email,
                activo = activo,
                tipo = tipo,
                cedula = cedula,
                empresa = empresa
            }) ;
        }
    }
}
