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
    public class MessageCategoryManager : IMessageCategoryService
    {
        private readonly IMessageCategoryDal _messagecategoryDal;
public MessageCategoryManager(IMessageCategoryDal messagecategoryDal)
        {
            _messagecategoryDal = messagecategoryDal;
        }


        public void TDelete(MessageCategory t)
        {
            throw new NotImplementedException();
        }

        public List<MessageCategory> TGetAll()
        {
           return _messagecategoryDal.GetAll();
        }

        public MessageCategory TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TInsert(MessageCategory t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(MessageCategory t)
        {
            throw new NotImplementedException();
        }
    }
}
