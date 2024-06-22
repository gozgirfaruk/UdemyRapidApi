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
    public class GuestMenager : IGuestService
    {
        private readonly IGuestDal _guestDal;

        public GuestMenager(IGuestDal guestDal)
        {
            _guestDal = guestDal;
        }

        public void TDelete(Guest entity)
        {
            _guestDal.Delete(entity);
        }

        public Guest TGetByID(int id)
        {
            return _guestDal.GetByID(id);
        }

        public List<Guest> TGetList()
        {
            return _guestDal.GetList();
        }

        public void TInsert(Guest entity)
        {
            _guestDal.Insert(entity);
        }

        public void TUpdate(Guest entity)
        {
            _guestDal.Update(entity);
        }
    }
}
