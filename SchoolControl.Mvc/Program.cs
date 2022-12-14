using AutoMapper;
using SchoolControl.BusinessLayer.Extensions;
using SchoolControl.Core.Mappers;
using SchoolControl.Repository.Db.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRepositoryDb();
builder.Services.AddSchoolBusinessLayer();

builder.Services.AddControllersWithViews();
var mapperConfig = new MapperConfiguration(mapperConfig =>
{
    mapperConfig.AddProfile<SchoolControlMapper>();
});
IMapper mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);
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
