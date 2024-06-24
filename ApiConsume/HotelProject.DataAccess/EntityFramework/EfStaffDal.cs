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
    public class EfStaffDal : GenericRepository<Staff>, IStaffDal
    {
        public EfStaffDal(ApiContext context) : base(context)
        {
        }

        public List<Staff> LastFourStaff()
        {
            var context = new ApiContext();
            var values = context.Staffies.Take(4).ToList();
            return values;  
        }

        public int StaffCount()
        {
            var context = new ApiContext();
            var values = context.Staffies.Count();
            return values;
        }
    }
}
