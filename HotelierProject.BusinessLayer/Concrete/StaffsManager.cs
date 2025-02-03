using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelierProject.BusinessLayer.Abstract;
using HotelierProject.DataAccessLayer.Abstract;
using HotelierProject.EntityLayer.Concrete;

namespace HotelierProject.BusinessLayer.Concrete
{
    public class StaffsManager : IStaffsService
    {
        private readonly IStaffsDal _stafssDal;

        public StaffsManager(IStaffsDal stafssDal)
        {
            _stafssDal = stafssDal;
        }

        public void TDelete(Staffs t)
        {
            _stafssDal.Delete(t);
        }

        public List<Staffs> TGetAll()
        {
            return _stafssDal.GetAll();
        }

        public Staffs TGetById(int id)
        {
            return _stafssDal.GetById(id);
        }

        public int TGetStaffCount()
        {
            return _stafssDal.GetStaffCount();
        }

        public void TInsert(Staffs t)
        {
            _stafssDal.Insert(t);
        }

        public List<Staffs> TLast4Staff()
        {
            return _stafssDal.Last4Staff();
        }

        public void TUpdate(Staffs t)
        {
            _stafssDal.Update
                (t);
        }
    }
}
