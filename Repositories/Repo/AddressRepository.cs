using Microsoft.EntityFrameworkCore;
using CourseWorkPIPS.Models;
using CourseWorkPIPS.Repositories.IRepo;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseWorkPIPS.Database;

namespace CourseWorkPIPS.Repositories.Repo
{
    public class AddressRepository : IAddressRepository
    {
        private readonly AppDbContext _context;
        private readonly ILogger<AddressRepository> _logger;

        public AddressRepository(AppDbContext context, ILogger<AddressRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public void Add(Address address)
        {
            try
            {
                _context.Addresses.Add(address);
                _context.SaveChanges();
                _logger.LogInformation("Адрес добавлен: {Id}", address.Id);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при добавлении адреса");
                throw;
            }
        }

        public void Update(Address address)
        {
            try
            {
                _context.Entry(address).State = EntityState.Modified;
                _context.SaveChanges();
                _logger.LogInformation("Адрес обновлён: {Id}", address.Id);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при обновлении адреса: {Id}", address?.Id ?? 0);
                throw;
            }
        }

        public void Delete(int id)
        {
            try
            {
                var address = _context.Addresses.Find(id);
                if (address != null)
                {
                    _context.Addresses.Remove(address);
                    _context.SaveChanges();
                    _logger.LogInformation("Адрес удалён: {Id}", id);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при удалении адреса: {Id}", id);
                throw;
            }
        }

        public Address GetById(int id)
        {
            try
            {
                var address = _context.Addresses.Find(id);
                _logger.LogInformation("Получен адрес: {Id}", id);
                return address;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при получении адреса: {Id}", id);
                throw;
            }
        }

        public List<Address> GetAll()
        {
            try
            {
                return _context.Addresses.ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при получении всех адресов");
                throw;
            }
        }
    }
}