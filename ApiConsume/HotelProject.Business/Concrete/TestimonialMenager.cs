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
    public class TestimonialMenager : ITestimonialService
    {
        private readonly ITestimonialDal _testimonialDal;

        public TestimonialMenager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public void TDelete(Testimonial entity)
        {
            _testimonialDal.Delete(entity); 
        }

        public Testimonial TGetByID(int id)
        {
           return _testimonialDal.GetByID(id);
        }

        public List<Testimonial> TGetList()
        {
            return _testimonialDal.GetList();
        }

        public void TInsert(Testimonial entity)
        {
            _testimonialDal.Insert(entity);
        }

        public int TTestCount()
        {
            return _testimonialDal.TestCount();
        }

        public void TUpdate(Testimonial entity)
        {
            _testimonialDal.Update(entity);
        }
    }
}
