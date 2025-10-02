using CourseWorkPIPS.Models.Enums;
using CourseWorkPIPS.Models;
using CourseWorkPIPS.Repositories.IRepo;
using CourseWorkPIPS.Services.IServ;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWorkPIPS.Services.Serv
{
    public class PassService : IPassService
    {
        private readonly IPassRepository _passRepo;
        private readonly ILogger<PassService> _logger;

        public PassService(IPassRepository passRepo, ILogger<PassService> logger)
        {
            _passRepo = passRepo;
            _logger = logger;
        }

        public void CreatePass(Pass pass)
        {
            try
            {
                var newPass = new Pass
                {
                    Code = pass.Code,
                    Type = pass.Type,
                    PeriodStart = pass.PeriodStart,
                    PeriodEnd = pass.PeriodEnd,
                    Kind = pass.Kind,
                    Status = pass.Status,
                    AddressId = pass.AddressId,
                    Name = pass.Name
                };

                _passRepo.Add(newPass);
                _logger.LogInformation("Создан пропуск с номером: {Pass}", newPass.Id);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при создании пропуска");
                throw;
            }
        }

        public void UpdatePass(Pass passs)
        {
            try
            {
                var pass = _passRepo.GetById(passs.Id);

                pass.Status = passs.Status;
                pass.PeriodStart = passs.PeriodStart;
                pass.PeriodEnd = passs.PeriodEnd;
                pass.Type = passs.Type;
                pass.AddressId = passs.AddressId;
                pass.Kind = passs.Kind;
                pass.Code = passs.Code;
                pass.Name = passs.Name;

                _passRepo.Update(pass);
                _logger.LogInformation("Обновлен пропуск с номером: {Pass}", passs.Id);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при обновлении пропуска: {Pass}", passs?.Id ?? 0);
                throw;
            }
        }

        public void DeletePass(int id)
        {
            try
            {
                _passRepo.Delete(id);
                _logger.LogInformation("Удален пропуск с номером: {Id}", id);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при удалении пропуска: {Id}", id);
                throw;
            }
        }

        public List<Pass> GetPassesByAddressId(int addressId)
        {
            try
            {
                _logger.LogInformation("Получены пропуска по адресу: {id}", addressId);
                var passes = _passRepo.GetAll();
                return passes.Where(p => p.AddressId == addressId).ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при получении пропусков по адресу: {id}", addressId);
                return new List<Pass>();
            }
        }

        public List<Pass> GetAllPasses()
        {
            try
            {
                return _passRepo.GetAll();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при получении всех пропусков");
                return new List<Pass>();
            }
        }

        public void UnbindPassesFromAddress(int addressId)
        {
            try
            {
                _logger.LogInformation("Отвязан пропуск с адреса: {id}", addressId);
                var passes = _passRepo.GetAll();
                foreach (var pass in passes.Where(p => p.AddressId == addressId))
                {
                    pass.AddressId = null;
                    _passRepo.Update(pass);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при отвязке пропусков от адреса: {id}", addressId);
                throw;
            }
        }

        public bool ExtendPass(int id, int days)
        {
            try
            {
                _logger.LogInformation("Пропуск {Id} продлен на: {days} дней", id, days);
                var pass = _passRepo.GetById(id);
                if (pass == null) return false;

                pass.PeriodEnd = pass.PeriodEnd.AddDays(days);
                _passRepo.Update(pass);
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка продления пропуска: {Id}", id);
                return false;
            }
        }

        public string SharePassCode(int passId)
        {
            try
            {
                var pass = _passRepo.GetById(passId);
                return pass?.Code ?? "Not found";
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при получении кода пропуска: {Id}", passId);
                return "Ошибка";
            }
        }

        public List<Pass> FilterPasses(PassKind? kind, PassType? type)
        {
            try
            {
                _logger.LogInformation("Отфильтровано");
                return _passRepo.Filter(kind, type);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка фильтрации пропусков");
                return new List<Pass>();
            }
        }

        public void UpdateStatus(int id, PassStatus newStatus)
        {
            try
            {
                var pass = _passRepo.GetById(id);
                if (pass != null)
                {
                    pass.Status = newStatus;
                    _passRepo.Update(pass);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка обновления статуса пропуска: {Id}", id);
                throw;
            }
        }

        public List<Pass> GenerateReport(DateTime startTime, DateTime endTime)
        {
            try
            {
                _logger.LogInformation("Создание отчёта");
                return _passRepo.GetAll()
                    .Where(p => p.PeriodStart >= startTime && p.PeriodEnd <= endTime)
                    .ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка генерации отчёта");
                return new List<Pass>();
            }
        }
    }
}