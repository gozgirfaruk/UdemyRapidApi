using HotelProject.Business.Abstract;
using HotelProject.Business.Concrete;
using HotelProject.DataAccess.Abstract;
using HotelProject.DataAccess.Concrete;
using HotelProject.DataAccess.EntityFramework;
using HotelProject.WebApi.Mapping;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ApiContext>();

builder.Services.AddScoped<IStaffDal,EfStaffDal>();
builder.Services.AddScoped<IStaffService,StaffMenager>();

builder.Services.AddScoped<IServiceService,ServiceMenager>();
builder.Services.AddScoped<IServiceDal,EfServiceDal>();

builder.Services.AddScoped<ITestimonialDal,EfTestimonialDal>();
builder.Services.AddScoped<ITestimonialService,TestimonialMenager>();

builder.Services.AddScoped<IAboutDal,EfAboutDal>();
builder.Services.AddScoped<IAboutService,AboutMenager>();

builder.Services.AddScoped<IRoomDal,EfRoomDal>();
builder.Services.AddScoped<IRoomService,RoomMenager>();

builder.Services.AddScoped<IBookingDal,EfBookingDal>();
builder.Services.AddScoped<IBookingService,BookingMenager>();

builder.Services.AddScoped<ISubscribeDal,EfSubscribeDal>();
builder.Services.AddScoped<ISubscribeService,SubscribeMenager>();

builder.Services.AddScoped<IContactDal,EfContactDal>();
builder.Services.AddScoped<IContactService,ContactMenager>();

builder.Services.AddScoped<IGuestDal,EfGuestDal>();
builder.Services.AddScoped<IGuestService, GuestMenager>();

builder.Services.AddScoped<ISendMessageDal,EfSendMessageDal>();
builder.Services.AddScoped<ISendMessageService,SendMessageMenager>();

builder.Services.AddScoped<IWorklocationDal,EfWorklocationDal>();
builder.Services.AddScoped<IWorklocationService,WorklocationMenager>();

builder.Services.AddScoped<IAppUserDal,EfAppUserDal>();
builder.Services.AddScoped<IAppUserService,AppUserMenager>();


builder.Services.AddAutoMapper(typeof(AutoMapperConfig));

builder.Services.AddCors(opt =>
{
    opt.AddPolicy("HotelierApi", opts =>
    {
        opts.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
});

builder.Services.AddControllersWithViews().AddJsonOptions(options=>options.JsonSerializerOptions.ReferenceHandler=ReferenceHandler.IgnoreCycles);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("HotelierApi");

app.UseAuthorization();

app.MapControllers();

app.Run();
