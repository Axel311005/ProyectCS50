using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Nomina
{
    public class ApiClient
    {
        private readonly HttpClient _httpClient;
        public IRepository<EmpleadoDto> Empleados { get; }
        public IRepository<DeduccionDto> Deducciones { get; }
        public IRepository<IngresoDto> Ingresos { get; }
        public IUserRepository LoginUsers { get; }
        public IUserRepository RegisterUsers { get; }
        public IRepository<NominaDto> Nominas { get; }
        

        public ApiClient()
        {
            string apiBaseUrl = ConfigurationManager.AppSettings["ApiBaseUrl"];
            _httpClient = new HttpClient { BaseAddress = new Uri(apiBaseUrl) };
            Empleados = new Repository<EmpleadoDto>(_httpClient, "Empleado");
            Deducciones = new Repository<DeduccionDto>(_httpClient, "Deduccion");
            Ingresos = new Repository<IngresoDto>(_httpClient, "Ingreso");
            LoginUsers = new UserRepository(_httpClient, "Auth/Login");
            RegisterUsers = new UserRepository(_httpClient, "Auth/register");
            Nominas = new Repository<NominaDto>(_httpClient, "Nomina");

            
        }

        public void SetAuthToken(string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", token);
        }
    }
}
