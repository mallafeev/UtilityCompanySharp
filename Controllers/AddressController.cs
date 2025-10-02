using CourseWorkPIPS.Models;
using CourseWorkPIPS.Repositories.IRepo;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkPIPS.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AddressController : ControllerBase
    {
        private readonly IAddressRepository _addressRepo;

        public AddressController(IAddressRepository addressRepo) => _addressRepo = addressRepo;

        // Создание адреса
        [HttpPost("create")]
        public IActionResult Create(
            [FromQuery] string street,
            [FromQuery] int house,
            [FromQuery] int countUses)
        {
            var newAddress = new Address { Street = street, House = house, CountUses = countUses };
            _addressRepo.Add(newAddress);
            return Created("", newAddress);
        }

        // Обновление адреса
        [HttpPut("update/{id}")]
        public IActionResult Update(int id,
            [FromQuery] string? street,
            [FromQuery] int? house,
            [FromQuery] int? countUses)
        {
            var address = _addressRepo.GetById(id);
            if (address == null) return NotFound();

            if (!string.IsNullOrEmpty(street)) address.Street = street;
            if (house.HasValue) address.House = house.Value;
            if (countUses.HasValue) address.CountUses = countUses.Value;

            _addressRepo.Update(address);
            return NoContent();
        }

        // Удаление адреса
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _addressRepo.Delete(id);
            return NoContent();
        }

        // Получение всех адресов
        [HttpGet("getAll")]
        public IActionResult GetAll() => Ok(_addressRepo.GetAll());
    }
}
