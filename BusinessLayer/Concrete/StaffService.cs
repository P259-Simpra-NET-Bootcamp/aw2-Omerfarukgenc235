using BusinessLayer.Abstract;
using BusinessLayer.FluentValidations;
using DataAccessLayer.Abstract;
using EntityLayer.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class StaffService : IStaffService
    {
        IStaffDal _staffDal;

        public StaffService(IStaffDal staffDal)
        {
            _staffDal = staffDal;
        }

        public bool Add(Staff staff)
        {
            var validator = new StaffValidator();
            var result = validator.Validate(staff);

            if (result.IsValid)
            {
                int status = _staffDal.Insert(staff);
                return status > 0;
            }
            else
            {
                throw new ValidationException(result.Errors);
            }
        }

        public bool Delete(int id)
        {
            var item = GetByID(id);
            int result = _staffDal.Delete(item);
            if (result > 0) return true;
            else return false;
        }

        public Staff GetByID(int id)
        {
            return _staffDal.Find(x => x.Id == id);
        }
      
        public List<Staff> GetList()
        {
            return _staffDal.List();
        }
        public List<Staff> GetListByCity(string city)
        {
            return _staffDal.List(x => x.City == city);
        }
        public List<Staff> FilterByAge(int age)
        {
            return _staffDal.GetStaffByAge(age);
        }
        public bool Update(Staff staff)
        {    
            var validator = new StaffValidator();
            var result = validator.Validate(staff);

            if (result.IsValid)
            {
                int status = _staffDal.Update(staff);
                return status > 0;
            }
            else
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}