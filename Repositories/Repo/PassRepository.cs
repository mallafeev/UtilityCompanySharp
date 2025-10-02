using Microsoft.EntityFrameworkCore;
using CourseWorkPIPS.Models;
using CourseWorkPIPS.Repositories.IRepo;
using Microsoft.Extensions.Logging;
using CourseWorkPIPS.Database;
using CourseWorkPIPS.Models.Enums;

namespace CourseWorkPIPS.Repositories.Repo
{
    public class PassRepository : IPassRepository
    {
        private readonly AppDbContext _context;
        private readonly ILogger<PassRepository> _logger;

        public PassRepository(AppDbContext context, ILogger<PassRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public void Add(Pass pass)
        {
            try
            {
                _context.Passes.Add(pass);
                _context.SaveChanges();
                _logger.LogInformation("Пропуск добавлен: {Id}", pass.Id);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при добавлении пропуска");
                throw;
            }
        }

        public void Update(Pass pass)
        {
            try
            {
                _context.Entry(pass).State = EntityState.Modified;
                _context.SaveChanges();
                _logger.LogInformation("Пропуск обновлён: {Id}", pass.Id);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при обновлении пропуска: {Id}", pass?.Id ?? 0);
                throw;
            }
        }

        public void Delete(int id)
        {
            try
            {
                var pass = _context.Passes.Find(id);
                if (pass != null)
                {
                    _context.Passes.Remove(pass);
                    _context.SaveChanges();
                    _logger.LogInformation("Пропуск удалён: {Id}", id);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при удалении пропуска: {Id}", id);
                throw;
            }
        }

        public Pass GetById(int id)
        {
            try
            {
                var pass = _context.Passes.Find(id);
                _logger.LogInformation("Получен пропуск: {Id}", id);
                return pass;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при получении пропуска: {Id}", id);
                throw;
            }
        }

        public List<Pass> GetAll() => _context.Passes.ToList();

        public List<Pass> Filter(PassKind? kind, PassType? type)
        {
            try
            {
                var query = _context.Passes.AsQueryable();

                if (kind.HasValue)
                    query = query.Where(p => p.Kind == kind.Value);

                if (type.HasValue)
                    query = query.Where(p => p.Type == type.Value);

                return query.ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка фильтрации пропусков");
                throw;
            }
        }
    }
}