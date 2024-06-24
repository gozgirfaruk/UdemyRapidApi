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
    public class AppUserMenager : IAppUserService
    {
        private readonly IAppUserDal _appuserDal;

        public AppUserMenager(IAppUserDal appuserDal)
        {
            _appuserDal = appuserDal;
        }

        public void TDelete(AppUser entity)
        {
            throw new NotImplementedException();
        }

        public AppUser TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<AppUser> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TInsert(AppUser entity)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(AppUser entity)
        {
            throw new NotImplementedException();
        }

        public List<AppUser> TUserWithLocation()
        {
            return _appuserDal.UserWithLocation();
        }
    }
}
