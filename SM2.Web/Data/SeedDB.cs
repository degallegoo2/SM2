
using SM2.Web.Data.Entities;
using SM2.Web.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SM2.Web.Data
{
    public class SeedDB
    {
        private readonly DataContext _context;
        private readonly IUserHelper _userHelper;

        public SeedDB(
            DataContext dataContext,
            IUserHelper userHelper)
        {
            _context = dataContext;
            _userHelper = userHelper;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckRoles();
            var manager = await CheckUserAsync("1010", "Daniel", "Gallego", "degallegoo2@gmail.com", "3136237481", "Calle Luna Calle Sol", "Admin");
            var customer = await CheckUserAsync("2020", "Daniel", "Gallego", "deestivengoo3@gmail.com", "3136237481", "Calle Luna Calle Sol", "Customer");            
            await CheckTypeCesantiaAsync();
            await CheckCityAsync();
            await CheckTypeDisabilityAsync();
            await CheckTypeLicenseAsync();
            await CheckTypeLoanAsync();
            await CheckType_request();
            await CheckStatusAsync();
            await CheckManagerAsync(manager);
            await CheckRepsAsync(customer);
        }

        private async Task CheckRoles()
        {
            await _userHelper.CheckRoleAsync("Admin");
            await _userHelper.CheckRoleAsync("Customer");
        }        

        private async Task<User> CheckUserAsync(
            string document,
            string firstName,
            string lastName,
            string email,
            string phone,
            string address,
            string role)
        {
            var user = await _userHelper.GetUserByEmailAsync(email);
            if (user == null)
            {
                user = new User
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Email = email,
                    UserName = email,
                    PhoneNumber = phone,
                    Address = address,
                    Document = document
                };
                await _userHelper.AddUserAsync(user, "123456");
                await _userHelper.AddUserToRoleAsync(user, role);
            }
            return user;
        }

        private async Task CheckTypeCesantiaAsync()
        {
            if (!_context.TypeCesantias.Any())
            {
                _context.TypeCesantias.Add(new TypeCesantia { name = "Empresa" });
                _context.TypeCesantias.Add(new TypeCesantia { name = "Fondo" });
                _context.TypeCesantias.Add(new TypeCesantia { name = "Empresa y Fondo" });
                await _context.SaveChangesAsync();
            }
        }
        private async Task CheckCityAsync()
        {
            if (!_context.Cities.Any())
            {
                _context.Cities.Add(new City { nameCity = "Medellín" });
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
            if (!_context.TypeDisabilities.Any())
            {
                _context.TypeDisabilities.Add(new TypeDisability { name = "Enfermedad general / Prorroga" });
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
            if (!_context.TypeLoans.Any())
            {
                _context.TypeLoans.Add(new TypeLoan { Name = "Prestamo de vivienta" });
                _context.TypeLoans.Add(new TypeLoan { Name = "Prestamo de Vehiculo" });
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckType_request()
        {
            if (!_context.Type_Requests.Any())
            {
                _context.Type_Requests.Add(new Type_Request {  Nombre = "Cesantías" });
                _context.Type_Requests.Add(new Type_Request {  Nombre = "Transfers" });
                _context.Type_Requests.Add(new Type_Request {  Nombre = "Disabilities" });
                _context.Type_Requests.Add(new Type_Request {  Nombre = "Licenses" });
                _context.Type_Requests.Add(new Type_Request {  Nombre = "Loans" });
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckStatusAsync()
        {
            if (!_context.States.Any())
            {
                _context.States.Add(new State {  Nomnbre = "Registrado" });
                _context.States.Add(new State {  Nomnbre = "En Gestión" });
                _context.States.Add(new State {  Nomnbre = "No Aprobado" });
                _context.States.Add(new State {  Nomnbre = "Tramitado" });
                await _context.SaveChangesAsync();
            }
        }

        

        private async Task CheckRepsAsync(User user)
         {
            if (!_context.Reps.Any())
            {
                _context.Reps.Add(new Rep { User = user });
                await _context.SaveChangesAsync();
            }
        }  

        private async Task CheckUserAsync(User user)
        {
            if (!_context.Reps.Any())
            {
                _context.Reps.Add(new Rep { User = user});
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckManagerAsync(User user)
        {
            if (!_context.Managers.Any())
            {
                _context.Managers.Add(new Manager { User = user });
                await _context.SaveChangesAsync();
            }
        }

    }
}
