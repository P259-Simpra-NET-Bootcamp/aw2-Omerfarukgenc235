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
        public EfStaffDal(Context dbContext) : base(dbContext)
        {
        }
    }

}
