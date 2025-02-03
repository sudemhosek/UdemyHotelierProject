using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelierProject.BusinessLayer.Abstract;
using HotelierProject.DataAccessLayer.Abstract;
using HotelierProject.DataAccessLayer.EntityFramework;
using HotelierProject.EntityLayer.Concrete;

namespace HotelierProject.BusinessLayer.Concrete
{
    public class AppUserManager : IAppUserService
    {
        private readonly IAppUserDal _appUseDal;

        public AppUserManager(IAppUserDal appUseDal)
        {
            _appUseDal = appUseDal;
        }

        public int TAppUserCount()
        {
            return  _appUseDal.AppUserCount();
        }

        public void TDelete(AppUser t)
        {
           _appUseDal.Delete(t);
        }

        public List<AppUser> TGetAll()
        {
            return _appUseDal.GetAll();
        }

        public AppUser TGetById(int id)
        {
            return _appUseDal.GetById(id);
        }

        public void TInsert(AppUser t)
        {
            _appUseDal.Insert(t);
        }

        public void TUpdate(AppUser t)
        {
           _appUseDal.Update(t);
        }

        public List<AppUser> TUserListWithWorkLocation()
        {
            return _appUseDal.UserListWithWorkLocation();
        }

        public List<AppUser> TUsersListWithWorkLocations()
        {
            return _appUseDal.UsersListWithWorkLocations();
        }
    }
}
