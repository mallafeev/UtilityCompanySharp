using CourseWorkPIPS.Models;
using CourseWorkPIPS.Repositories.IRepo;
using CourseWorkPIPS.Services.IServ;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkPIPS.Services.Serv
{
    public class AddressService : IAddressService
    {
        private readonly IAddressRepository _addressRepo;
        private readonly ILogger<AddressService> _logger;
        private readonly IPassService _passService;

        public AddressService(IAddressRepository addressRepo, ILogger<AddressService> logger, IPassService passService)
        {
            _addressRepo = addressRepo;
            _logger = logger;
            _passService = passService;
        }

        public Address CreateAddress(Address adres)
        {
            try
            {
                var newAddress = new Address
                {
                    Street = adres.Street,
                    House = adres.House,
                    CountUses = adres.CountUses
                };
                _addressRepo.Add(newAddress);
                _logger.LogInformation("Создан адрес с номером: {Id}", newAddress.Id);
                return newAddress;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при создании адреса");
                throw;
            }
        }

        public void UpdateAddress(Address adres)
        {
            try
            {
                _logger.LogInformation("Обновление адреса номер: {id}", adres.Id);
                var address = _addressRepo.GetById(adres.Id);
                if (address != null)
                {
                    address.Street = adres.Street;
                    address.House = adres.House;
                    address.CountUses = adres.CountUses;
                    _addressRepo.Update(address);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при обновлении адреса: {id}", adres?.Id ?? 0);
                throw;
            }
        }

        public void DeleteAddress(int id)
        {
            try
            {
                _passService.UnbindPassesFromAddress(id);

                var addressToDelete = _addressRepo.GetById(id);
                if (addressToDelete != null)
                {
                    _addressRepo.Delete(addressToDelete.Id);
                }
                _logger.LogInformation("Удален адрес: {id}", id);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при удалении адреса: {id}", id);
                throw;
            }
        }

        public List<Address> GetAllAddresses()
        {
            try
            {
                return _addressRepo.GetAll();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при получении всех адресов");
                throw;
            }
        }

        public void IncrementUses(int id)
        {
            try
            {
                var adres = _addressRepo.GetById(id);
                if (adres != null)
                {
                    adres.CountUses++;
                    _addressRepo.Update(adres);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при увеличении счётчика использования: {id}", id);
                throw;
            }
        }

        public int GetUseCount(int id)
        {
            try
            {
                var adres = _addressRepo.GetById(id);
                return adres?.CountUses ?? 0;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при получении счётчика использования для адреса: {id}", id);
                throw;
            }
        }
    }
}