﻿using HotelProject.Business.Abstract;
using HotelProject.DataAccess.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Business.Concrete
{
    public class StaffMenager : IStaffService
    {
        private readonly IStaffDal _staffDal;

        public StaffMenager(IStaffDal staffDal)
        {
            _staffDal = staffDal;
        }

        public void TDelete(Staff entity)
        {
            _staffDal.Delete(entity);
        }

        public Staff TGetByID(int id)
        {
            return _staffDal.GetByID(id);
        }

        public List<Staff> TGetList()
        {
            return _staffDal.GetList();
        }

        public void TInsert(Staff entity)
        {
            _staffDal.Insert(entity);
        }

        public List<Staff> TLastFourStaff()
        {
            return _staffDal.LastFourStaff();
        }

        public int TStaffCount()
        {
            return _staffDal.StaffCount();
        }

        public void TUpdate(Staff entity)
        {
            _staffDal.Update(entity);
        }
    }
}
