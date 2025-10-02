using CourseWorkPIPS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkPIPS
{
    public class ApiService
    {
        private readonly HttpClient _client;

        public ApiService()
        {
            // Укажите URL вашего API (где запущен ASP.NET Core)
            _client = new HttpClient
            {
                BaseAddress = new Uri("http://localhost:5000/")
            };
        }

        // ==== Работа с пропусками ====

        // Получить все пропуски
        public async Task<List<Pass>> GetAllPassesAsync()
        {
            var response = await _client.GetAsync("api/Pass/getAll");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<List<Pass>>();
        }

        // Получить пропуск по ID
        public async Task<Pass> GetPassByIdAsync(int id)
        {
            var response = await _client.GetAsync($"api/Pass/{id}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Pass>();
        }

        // Создать новый пропуск
        public async Task<HttpResponseMessage> CreatePassAsync(Pass pass)
        {
            return await _client.PostAsJsonAsync("api/Pass/create", pass);
        }

        // Обновить пропуск
        public async Task<HttpResponseMessage> UpdatePassAsync(Pass pass)
        {
            return await _client.PutAsJsonAsync($"api/Pass/update/{pass.Id}", pass);
        }

        // Удалить пропуск
        public async Task<HttpResponseMessage> DeletePassAsync(int id)
        {
            return await _client.DeleteAsync($"api/Pass/delete/{id}");
        }

        // ==== Работа с адресами ====

        // Получить все адреса
        public async Task<List<Address>> GetAddressesAsync()
        {
            var response = await _client.GetAsync("api/Address/getAll");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<List<Address>>();
        }
    }
}
