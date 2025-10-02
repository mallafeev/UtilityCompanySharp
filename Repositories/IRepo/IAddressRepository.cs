using CourseWorkPIPS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkPIPS.Repositories.IRepo
{
    public interface IAddressRepository
    {
        void Add(Address address);
        void Update(Address address);
        void Delete(int id);
        Address GetById(int id);
        List<Address> GetAll();
    }
}
