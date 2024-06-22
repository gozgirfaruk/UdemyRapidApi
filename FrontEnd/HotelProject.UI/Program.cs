using FluentValidation;
using FluentValidation.AspNetCore;
using HotelProject.Business.Abstract;
using HotelProject.Business.Concrete;
using HotelProject.DataAccess.Abstract;
using HotelProject.DataAccess.Concrete;
using HotelProject.DataAccess.EntityFramework;
using HotelProject.EntityLayer.Concrete;
using HotelProject.UI.Dtos.GuestDtos;
using HotelProject.UI.Mapping;
using HotelProject.UI.ValidationRules.GuestValidator;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddHttpClient();
builder.Services.AddAutoMapper(typeof(AutoMapperConfig));

builder.Services.AddDbContext<ApiContext>();
builder.Services.AddIdentity<AppUser,AppRole>().AddEntityFrameworkStores<ApiContext>();
builder.Services.AddTransient<IValidator<CreateGuestDto>, CreateGuestValidator>();
builder.Services.AddControllersWithViews().AddFluentValidation();

builder.Services.AddScoped<IBookingDal, EfBookingDal>();
builder.Services.AddScoped<IBookingService,BookingMenager>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
