using HotelierProject.BusinessLayer.Abstract;
using HotelierProject.BusinessLayer.Concrete;
using HotelierProject.DataAccessLayer.Abstract;
using HotelierProject.DataAccessLayer.Concrete;
using HotelierProject.DataAccessLayer.EntityFramework;
using HotelierProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Hosting;
using Microsoft.OpenApi.Models;
using AutoMapper;



var builder = WebApplication.CreateBuilder(args);

// Add IHttpClientFactory
builder.Services.AddHttpClient();

// Diðer servisler ve baðýmlýlýklar
builder.Services.AddDbContext<Context>();
builder.Services.AddScoped<IStaffsDal, EfStaffsDal>();
builder.Services.AddScoped<IStaffsService, StaffsManager>();
builder.Services.AddScoped<IRoomDal, EfRoomDal>();
builder.Services.AddScoped<IRoomService, RoomManager>();
builder.Services.AddScoped<ISubscribeDal, EfSubscribeDal>();
builder.Services.AddScoped<ISubscribeService, SubscribeManager>();
builder.Services.AddScoped<ITestimonialDal, EfTestimonialDal>();
builder.Services.AddScoped<ITestimonialService, TestimonialManager>();
builder.Services.AddScoped<IServiceDal, EfServiceDal>();
builder.Services.AddScoped<IServiceService, ServiceManager>();
builder.Services.AddScoped<IAboutService, AboutManager>();
builder.Services.AddScoped<IAboutDal,EfAboutDal>();
builder.Services.AddScoped<IBookingDal,EfBooking>();
builder.Services.AddScoped<IBookingService,BookingManager>();
builder.Services.AddScoped<IMessageCategoryDal, EfMessageCategoryDal>();
builder.Services.AddScoped<IMessageCategoryService, MessageCategoryManager>();
builder.Services.AddScoped<IGuestDal, EfGuestDal>();
builder.Services.AddScoped<IGuestService, GuestManager>();
builder.Services.AddScoped<ISendMessageDal,EfSendMessageDal>();
builder.Services.AddScoped<ISendMessageService,SendMessageManager >();
builder.Services.AddScoped<IContactDal, EfContactDal>();
builder.Services.AddScoped<IContactService,ContactManager>();
builder.Services.AddScoped<IWorkLocationDal, EfWorkLocationDal>();
builder.Services.AddScoped<IWorkLocationService,WorkLocationManager>(); 
builder.Services.AddScoped<IAppUserDal, EfAppUserDal>();
builder.Services.AddScoped<IAppUserService, AppUserManager>();
   


builder.Services.AddAutoMapper(typeof(Program));

// CORS policy
builder.Services.AddCors(opt =>
{
    opt.AddPolicy("OtelApiCors", opts =>
    {
        opts.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
    });
});

// JSON options
builder.Services.AddControllers()
    .AddJsonOptions(options =>
        options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles);

// Swagger config
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "HotelProject.WebApi", Version = "v1" });
});

// Endpoints API Explorer
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

// Swagger in development environment
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger(); // Enable Swagger
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "HotelProject.WebApi v1"));
}



app.UseAuthorization();
app.UseCors("OtelApiCors");
app.MapControllers();

app.Run();


