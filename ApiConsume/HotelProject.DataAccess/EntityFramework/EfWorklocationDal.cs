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
    public class EfWorklocationDal : GenericRepository<WorkLocation>, IWorklocationDal
    {
        public EfWorklocationDal(ApiContext context) : base(context)
        {
        }
    }
}
