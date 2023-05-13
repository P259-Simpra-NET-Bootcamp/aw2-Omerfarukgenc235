using EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IStaffService
    {
        List<Staff> GetList();
        List<Staff> GetListByCity(string city);
        List<Staff> FilterByAge(int age);
        bool Add(Staff staff);
        Staff GetByID(int id);
        bool Delete(int id);
        bool Update(Staff staff);
    }
}