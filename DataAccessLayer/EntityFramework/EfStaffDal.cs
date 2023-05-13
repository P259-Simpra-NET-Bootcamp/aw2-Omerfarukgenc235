using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfStaffDal : Repository<Staff>, IStaffDal
    {
        private readonly DbContextOptions<Context> _options;

        public EfStaffDal(DbContextOptions<Context> options) : base(new Context(options))
        {
            _options = options;
        }

        public List<Staff> GetStaffByAge(int age)
        {
            using (var context = new Context(_options))
            {
                DateTime dateOfBirth = DateTime.Now.AddYears(-age);
                return context.Staffs.Where(s => s.DateOfBirth > dateOfBirth).ToList();
            }
        }
    }
}
