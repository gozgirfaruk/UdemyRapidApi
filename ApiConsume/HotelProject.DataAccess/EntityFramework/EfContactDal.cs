﻿using HotelProject.DataAccess.Abstract;
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
    public class EfContactDal : GenericRepository<Contact>, IContactDal
    {
        public EfContactDal(ApiContext context) : base(context)
        {
        }

        public int GetContactCount()
        {
            var context = new ApiContext();
            var value = context.Contacts.Count();
            return value;
        }
    }
}
