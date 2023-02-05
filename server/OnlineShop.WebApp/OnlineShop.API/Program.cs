using Microsoft.EntityFrameworkCore;
using OnlineShop.Bll;
using OnlineShop.Bll.Interfaces;
using OnlineShop.Bll.Services;
using OnlineShop.Dal;
using OnlineShop.Dal.Interfaces;
using OnlineShop.Dal.Repositories;
using OnlineShop.Domain.Auth;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddScoped(typeof(IRepository<>), typeof(EFCoreRepository<>));
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IColorService, ColorService>();
builder.Services.AddScoped<ISizeService, SizeService>();
builder.Services.AddScoped<IOrderService, OrderService>();

builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(BllAssemblyMarker));

builder.Services.AddDbContext<OnlineShopDbContext>(optionBuilder =>
{
    optionBuilder.UseLazyLoadingProxies().UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddIdentity<User, Role>(options =>
{
    options.Password.RequiredLength = 8;
})
.AddEntityFrameworkStores<OnlineShopDbContext>();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseRouting();

app.UseCors(configurePolicy => configurePolicy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
