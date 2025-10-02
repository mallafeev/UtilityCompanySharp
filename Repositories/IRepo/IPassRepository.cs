using CourseWorkPIPS.Models.Enums;
using CourseWorkPIPS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkPIPS.Repositories.IRepo
{
    public interface IPassRepository
    {
        void Add(Pass pass);
        void Update(Pass pass);
        void Delete(int id);
        Pass GetById(int id);
        List<Pass> GetAll();
        List<Pass> Filter(PassKind? kind = null, PassType? type = null);
    }
}
