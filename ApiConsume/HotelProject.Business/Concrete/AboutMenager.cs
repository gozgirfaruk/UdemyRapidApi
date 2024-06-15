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
    public class AboutMenager : IAboutService
    {
        private readonly IAboutDal _aboutDal;

        public AboutMenager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void TDelete(AboutUs entity)
        {
            _aboutDal.Delete(entity);
        }

        public AboutUs TGetByID(int id)
        {
            return _aboutDal.GetByID(id);
        }

        public List<AboutUs> TGetList()
        {
            return _aboutDal.GetList();
        }

        public void TInsert(AboutUs entity)
        {
            _aboutDal.Insert(entity);
        }

        public void TUpdate(AboutUs entity)
        {
            _aboutDal.Update(entity);
        }
    }
}
