using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelierProject.DataAccessLayer.Abstract;
using HotelierProject.DataAccessLayer.Concrete;
using HotelierProject.DataAccessLayer.Repositories;
using HotelierProject.EntityLayer.Concrete;

namespace HotelierProject.DataAccessLayer.EntityFramework
{
    public class EfStaffsDal : GenericRepository<Staffs>, IStaffsDal
    {
        public EfStaffsDal(Context context) : base(context)
        {
        }

        public int GetStaffCount()
        {
            using var context = new Context();
            var value = context.staffs.Count();
            return value;
        }

        public List<Staffs> Last4Staff()
        {
            using var context = new Context();
            var values = context.staffs.OrderByDescending(x => x.StaffsId).Take(4).ToList();
            return values;
        }
    }
}
