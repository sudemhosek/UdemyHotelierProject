using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelierProject.EntityLayer.Concrete;

namespace HotelierProject.BusinessLayer.Abstract
{
    public interface IRoomService:IGenericService<Room>
    {
        int TRoomCount();
    }
}
