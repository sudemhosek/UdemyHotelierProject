using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelierProject.EntityLayer.Concrete;

namespace HotelierProject.BusinessLayer.Abstract
{
    public interface IStaffsService : IGenericService<Staffs>
    {
        int TGetStaffCount();
        List<Staffs> TLast4Staff();
    }
}
