using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Business.Abstract
{
    public interface IBookingService : IGenericService<Booking>
    {
        void TApproveStatus(int id);
        void TCancelStatus(int id);
    }
}
