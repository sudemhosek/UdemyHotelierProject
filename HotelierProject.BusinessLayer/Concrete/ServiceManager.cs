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
    public class ServiceManager : IServiceService
    {
        private readonly IServiceDal _serviceDal;

        public ServiceManager(IServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
        }

        public void TDelete(Service t)
        {
            _serviceDal.Delete(t);
        }

        public List<Service> TGetAll()
        {
          return _serviceDal.GetAll();
        }

        public Service TGetById(int id)
        {
           return _serviceDal.GetById(id);
        }

        public void TInsert(Service t)
        {
           _serviceDal.Insert(t);
        }

        public void TUpdate(Service t)
        {
           _serviceDal.Update(t);
        }
    }
}
