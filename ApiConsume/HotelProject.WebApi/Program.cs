using HotelProject.Business.Abstract;
using HotelProject.Business.Concrete;
using HotelProject.DataAccess.Abstract;
using HotelProject.DataAccess.Concrete;
using HotelProject.DataAccess.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ApiContext>();

builder.Services.AddScoped<IStaffDal,EfStaffDal>();
builder.Services.AddScoped<IStaffService,StaffMenager>();

builder.Services.AddScoped<IServiceService,ServiceMenager>();
builder.Services.AddScoped<IServiceDal,EfServiceDal>();

builder.Services.AddScoped<ITestimonialDal,EfTestimonialDal>();
builder.Services.AddScoped<ITestimonialService,TestimonialMenager>();


builder.Services.AddScoped<IRoomDal,EfRoomDal>();
builder.Services.AddScoped<IRoomService,RoomMenager>();

builder.Services.AddScoped<ISubscribeDal,EfSubscribeDal>();
builder.Services.AddScoped<ISubscribeService,SubscribeMenager>();


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

app.UseAuthorization();

app.MapControllers();

app.Run();
