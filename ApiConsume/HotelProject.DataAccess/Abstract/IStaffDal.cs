﻿using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccess.Abstract
{
    public interface IStaffDal : IGenericDal<Staff>
    {
        public int StaffCount();
        public List<Staff> LastFourStaff();
    }
}
