using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelierProject.BusinessLayer.Abstract;
using HotelierProject.DataAccessLayer.Abstract;
using HotelierProject.EntityLayer;

namespace HotelierProject.BusinessLayer.Concrete
{
	public class WorkLocationManager : IWorkLocationService
	{
		private readonly IWorkLocationDal _workLocation;

		public WorkLocationManager(IWorkLocationDal workLocation)
		{
			_workLocation = workLocation;
		}

		public void TDelete(WorkLocation t)
		{
			_workLocation.Delete(t);
		}

		public List<WorkLocation> TGetAll()
		{
			return _workLocation.GetAll();
		}

		public WorkLocation TGetById(int id)
		{
			return _workLocation.GetById(id);
		}

		public void TInsert(WorkLocation t)
		{
			_workLocation.Insert(t);
		}

		public void TUpdate(WorkLocation t)
		{
			_workLocation.Update
				(t);
		}
	}
}
