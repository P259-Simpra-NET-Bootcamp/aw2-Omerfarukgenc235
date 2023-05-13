using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace SimpraOdev2.ServiceExtension
{
    public static class Extension
    {
        public static void AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {

            #region Veri Tabanı Bağlantısı
            services.AddDbContext<Context>(opt =>
                opt.UseSqlServer(configuration.GetConnectionString("SqlServerConnection")));
            #endregion

            #region Staff
            services.AddScoped<IStaffDal, EfStaffDal>();
            services.AddScoped<IStaffService, StaffService>();
            #endregion
        }
    }
}

