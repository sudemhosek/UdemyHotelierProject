using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelierProject.EntityLayer.Concrete;

namespace HotelierProject.DataAccessLayer.Abstract
{
    public interface IRoomDal:IGenericDal<Room>
    {
        int RoomCount();
    }
}
