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
    public class WorklocationMenager : IWorklocationService
    {
        private readonly IWorklocationDal _locationDal;

        public WorklocationMenager(IWorklocationDal locationDal)
        {
            _locationDal = locationDal;
        }

        public void TDelete(WorkLocation entity)
        {
            _locationDal.Delete(entity);
        }

        public WorkLocation TGetByID(int id)
        {
           return _locationDal.GetByID(id); 
        }

        public List<WorkLocation> TGetList()
        {
            return _locationDal.GetList();
        }

        public void TInsert(WorkLocation entity)
        {
            _locationDal.Insert(entity);    
        }

        public void TUpdate(WorkLocation entity)
        {
            _locationDal.Update(entity);
        }
    }
}
