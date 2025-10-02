using CourseWorkPIPS.Models.Enums;
using CourseWorkPIPS.Models;
using CourseWorkPIPS.Repositories.IRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CourseWorkPIPS.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PassController : ControllerBase
    {
        private readonly IPassRepository _passRepo;

        public PassController(IPassRepository passRepo) => _passRepo = passRepo;

        // Создание пропуска
        [HttpPost("create")]
        public IActionResult Create(
            [FromQuery] PassType type,
            [FromQuery] DateTime periodStart,
            [FromQuery] DateTime periodEnd,
            [FromQuery] PassKind kind,
            [FromQuery] PassStatus status,
            [FromQuery] string code,
            [FromQuery] int addressId,
            [FromQuery] string name)
        {
            var newPass = new Pass
            {
                Code = code,
                Type = type,
                PeriodStart = periodStart,
                PeriodEnd = periodEnd,
                Kind = kind,
                Status = status,
                AddressId = addressId,
                Name = name,
            };

            _passRepo.Add(newPass);
            return Created("", newPass);
        }

        // Обновление пропуска
        [HttpPut("update/{id}")]
        public IActionResult Update(int id,
            [FromQuery] PassType? type,
            [FromQuery] DateTime? periodStart,
            [FromQuery] DateTime? periodEnd,
            [FromQuery] PassKind? kind,
            [FromQuery] PassStatus? status,
            [FromQuery] string? code,
            [FromQuery] int? addressId,
            [FromQuery] string name)
        {
            var pass = _passRepo.GetById(id);
            if (pass == null) return NotFound();

            // Обновляем только переданные поля
            if (type.HasValue) pass.Type = type.Value;
            if (type.HasValue) pass.PeriodStart = periodStart.Value;
            if (type.HasValue) pass.PeriodEnd = periodEnd.Value;
            if (kind.HasValue) pass.Kind = kind.Value;
            if (status.HasValue) pass.Status = status.Value;
            if (code != null) pass.Code = code;
            if (addressId.HasValue) pass.AddressId = addressId.Value;
            pass.Name = name;

            _passRepo.Update(pass);
            return NoContent();
        }

        // Удаление пропуска
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _passRepo.Delete(id);
            return NoContent();
        }

        // Получение всех пропусков
        [HttpGet("getAll")]
        public IActionResult GetAll() => Ok(_passRepo.GetAll());


        // Фильтрация пропусков
        [HttpGet("getFilteredPasses")]
        public IActionResult GetFilteredPasses(
            [FromQuery] PassKind? kind,
            [FromQuery] PassType? type)
        {
            return Ok(_passRepo.Filter(kind, type));
        }

        // Генерация отчета
        [HttpGet("getReportTable")]
        public IActionResult GetReportTable(
            [FromQuery] DateTime startTime,
            [FromQuery] DateTime endTime)
        {
            // Реализуйте логику формирования отчета
            var report = _passRepo.GetAll()
                .Where(p => p.PeriodStart >= startTime && p.PeriodEnd <= endTime)
                .ToList();

            return Ok(report);
        }
    }
}
