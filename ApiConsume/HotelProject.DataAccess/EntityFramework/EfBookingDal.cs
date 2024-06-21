using HotelProject.DataAccess.Abstract;
using HotelProject.DataAccess.Concrete;
using HotelProject.DataAccess.Repositories;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccess.EntityFramework
{
    public class EfBookingDal : GenericRepository<Booking>, IBookingDal
    {
        public EfBookingDal(ApiContext context) : base(context)
        {
        }

        public void ApproveStatus(int id)
        {
            using ApiContext context = new ApiContext();
            var values = context.Bookings.Where(x => x.BookingID == id).FirstOrDefault();
            values.Status = true;
            context.SaveChanges();
        }

        public void CancelStatus(int id)
        {
            using ApiContext context = new ApiContext();
            var values = context.Bookings.Where(x=>x.BookingID==id).FirstOrDefault();
            values.Status = false;
            context.SaveChanges();
        }
    }
}
