using HotelProject.Business.Abstract;
using HotelProject.DataAccess.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Business.Concrete
{
    public class SendMessageMenager : ISendMessageService
    {
        private readonly ISendMessageDal _sendmessageDal;

        public SendMessageMenager(ISendMessageDal sendmessageDal)
        {
            _sendmessageDal = sendmessageDal;
        }

        public void TDelete(SendMessage entity)
        {
           _sendmessageDal.Delete(entity);
        }

        public SendMessage TGetByID(int id)
        {
            return _sendmessageDal.GetByID(id);
        }

        public List<SendMessage> TGetList()
        {
            return _sendmessageDal.GetList();
        }

        public void TInsert(SendMessage entity)
        {
            _sendmessageDal.Insert(entity);
        }

        public void TUpdate(SendMessage entity)
        {
            _sendmessageDal.Update(entity);
        }
    }
}
