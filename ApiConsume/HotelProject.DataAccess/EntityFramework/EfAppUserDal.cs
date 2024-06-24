using HotelProject.DataAccess.Abstract;
using HotelProject.DataAccess.Concrete;
using HotelProject.DataAccess.Repositories;
using HotelProject.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccess.EntityFramework
{
    public class EfAppUserDal : GenericRepository<AppUser>, IAppUserDal
    {
        public EfAppUserDal(ApiContext context) : base(context)
        {
        }

        public List<AppUser> UserWithLocation()
        {
            var context = new ApiContext();
            var values = context.Users.Include(x=>x.WorkLocation).ToList();
            return values;
        }
    }
}
