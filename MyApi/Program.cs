using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MyApi.Data.Context;
using MyApi.Data.Repositories;
using MyApi.Data.Repositories.person;
using MyApi.Data.Repositories.Productrepos;
using MyApi.Service;
using MyApi.Service.PersonService;
using MyApi.Service.ProductService;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//DB Config//haf�zaya bir tane LMSDBContext tipinde tip(instance) ��kart�yorumki di�er alanlarda kullanaca��m.
builder.Services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));



//dependecy injection
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped<IPersonRepository, PersonRepository>();
builder.Services.AddScoped<IPersonService, PersonService>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IProductService, ProductService>();


var mapperConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new MyApi.Service.Mappers.MappingProfile());
});
IMapper mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);




var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
