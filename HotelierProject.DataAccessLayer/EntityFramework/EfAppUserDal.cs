using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelierProject.DataAccessLayer.Abstract;
using HotelierProject.DataAccessLayer.Concrete;
using HotelierProject.DataAccessLayer.Repositories;
using HotelierProject.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace HotelierProject.DataAccessLayer.EntityFramework
{
    public class EfAppUserDal : GenericRepository<AppUser>, IAppUserDal
    {
        public EfAppUserDal(Context context) : base(context)
        {
        }

        int IAppUserDal.AppUserCount()
        {
            var context = new Context();
            var value = context.Users.Count();
            return value;
        }

        List<AppUser> IAppUserDal.UserListWithWorkLocation()
        {
            var context = new Context();
            return context.Users.Include(x => x.WorkLocation).ToList();
        }

        List<AppUser> IAppUserDal.UsersListWithWorkLocations()
        {
            var context = new Context();
            var values = context.Users.ToList();
            return values.ToList();
        }
    }

    
    
}
