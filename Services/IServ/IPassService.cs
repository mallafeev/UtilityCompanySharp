using CourseWorkPIPS.Models.Enums;
using CourseWorkPIPS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkPIPS.Services.IServ
{
    public interface IPassService
    {
        void CreatePass(Pass pass);
        void UpdatePass(Pass pass);
        void DeletePass(int id);
        List<Pass> GetAllPasses();
        List<Pass> GetPassesByAddressId(int addressId);
        void UnbindPassesFromAddress(int addressId);
        bool ExtendPass(int id, int days);
        string SharePassCode(int passId);
        List<Pass> FilterPasses(PassKind? kind, PassType? type);
        void UpdateStatus(int id, PassStatus newStatus);
        List<Pass> GenerateReport(DateTime startTime, DateTime endTime);
    }
}
