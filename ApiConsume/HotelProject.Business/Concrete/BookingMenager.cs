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
    public class BookingMenager : IBookingService
    {
        private readonly IBookingDal _bookingDal;

        public BookingMenager(IBookingDal bookingDal)
        {
            _bookingDal = bookingDal;
        }

        public void TApproveStatus(int id)
        {
            _bookingDal.ApproveStatus(id);
        }

        public void TCancelStatus(int id)
        {
            _bookingDal.CancelStatus(id);
        }

        public void TDelete(Booking entity)
        {
            _bookingDal.Delete(entity);
        }

        public Booking TGetByID(int id)
        {
            return _bookingDal.GetByID(id);
        }

        public List<Booking> TGetList()
        {
            return _bookingDal.GetList();
        }

        public void TInsert(Booking entity)
        {
            _bookingDal.Insert(entity);
        }

        public List<Booking> TLastReservation()
        {
            return _bookingDal.LastReservation();
        }

        public void TUpdate(Booking entity)
        {
            _bookingDal.Update(entity);
        }
    }
}
