﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelierProject.EntityLayer.Concrete;

namespace HotelierProject.DataAccessLayer.Abstract
{
    public interface IAppUserDal:IGenericDal<AppUser>
    {
        List<AppUser> UserListWithWorkLocation();
        List<AppUser> UsersListWithWorkLocations();
        int AppUserCount();
    }
}
