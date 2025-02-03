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
    public class SendMessageManager : ISendMessageService
    {
        private readonly ISendMessageDal _sendMessageDal;
        public SendMessageManager(ISendMessageDal sendMessageDal)
        {
            _sendMessageDal = sendMessageDal;
        }

        public void TDelete(SendMessage t)
        {
           _sendMessageDal.Delete(t);
        }

        public List<SendMessage> TGetAll()
        {
           return _sendMessageDal.GetAll();
        }

        public SendMessage TGetById(int id)
        {
            return _sendMessageDal.GetById(id);
        }

        public void TInsert(SendMessage t)
        {_sendMessageDal.Insert(t);
        }

        public void TUpdate(SendMessage t)
        {
           _sendMessageDal.Update(t);
        }
       

        public int TGetSendMessageCount()
        {
             return _sendMessageDal.GetSendMessageCount();
        }
    }
}
