using CourseWorkPIPS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkPIPS.Services.IServ
{
    public interface IAddressService
    {
        Address CreateAddress(Address adres);
        void UpdateAddress(Address adres);
        void DeleteAddress(int id);
        List<Address> GetAllAddresses();
        void IncrementUses(int id);
        int GetUseCount(int id);


    }
}
