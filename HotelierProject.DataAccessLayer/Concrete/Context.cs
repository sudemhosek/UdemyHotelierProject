using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelierProject.EntityLayer;
using HotelierProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HotelierProject.DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-5UD3UEV\\SQLEXPRESS; initial catalog=HotelApiDB ; integrated security = true");
        }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Service> services { get; set; }
        public DbSet<Staffs> staffs { get; set; }
        public DbSet<Subscribe> subscribe { get; set; }
        public DbSet <Testimonial> testimonials { get; set;}
        public DbSet<About> abouts { get; set; }
        public DbSet<Booking> bookings { get; set; }
        public DbSet<Guest> guest { get; set; }
      public DbSet<WorkLocation> worklocations { get; set; }
        public DbSet<MessageCategory> messageCategories { get; set; }
        public DbSet<SendMessage> sendMessages { get; set; } 
        public DbSet<Contact> contacts { get; set; }
    }
}
