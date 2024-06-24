using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccess.Abstract
{
    public interface IWorklocationDal : IGenericDal<WorkLocation>
    {
        public int LocationCount();
    }
}
