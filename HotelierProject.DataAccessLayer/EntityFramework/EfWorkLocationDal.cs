﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelierProject.DataAccessLayer.Abstract;
using HotelierProject.DataAccessLayer.Concrete;
using HotelierProject.DataAccessLayer.Repositories;
using HotelierProject.EntityLayer;

namespace HotelierProject.DataAccessLayer.EntityFramework
{
	public class EfWorkLocationDal : GenericRepository<WorkLocation>, IWorkLocationDal
	{
		public EfWorkLocationDal(Context context) : base(context)
		{
		}
	}
}
