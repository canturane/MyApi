using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MyApi.Data.Context;
using MyApi.Data.Repositories;
using MyApi.Data.Repositories.person;
<<<<<<< HEAD
<<<<<<< HEAD
using MyApi.Data.Repositories.Productrepos;
using MyApi.Service;
using MyApi.Service.PersonService;
using MyApi.Service.ProductService;

=======
using MyApi.Service.PersonService;
>>>>>>> 288b9a8295fb51213e8c2ea94c79e9c386a17eef
=======
using MyApi.Service.PersonService;
>>>>>>> 288b9a8295fb51213e8c2ea94c79e9c386a17eef

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


<<<<<<< HEAD
<<<<<<< HEAD
//DB Config//hafï¿½zaya bir tane LMSDBContext tipinde tip(instance) ï¿½ï¿½kartï¿½yorumki diï¿½er alanlarda kullanacaï¿½ï¿½m.
=======
//DB Config//hafýzaya bir tane LMSDBContext tipinde tip(instance) çýkartýyorumki diðer alanlarda kullanacaðým.
>>>>>>> 288b9a8295fb51213e8c2ea94c79e9c386a17eef
=======
//DB Config//hafýzaya bir tane LMSDBContext tipinde tip(instance) çýkartýyorumki diðer alanlarda kullanacaðým.
>>>>>>> 288b9a8295fb51213e8c2ea94c79e9c386a17eef
builder.Services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));



//dependecy injection
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped<IPersonRepository, PersonRepository>();
builder.Services.AddScoped<IPersonService, PersonService>();
<<<<<<< HEAD
<<<<<<< HEAD
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IProductService, ProductService>();
=======
>>>>>>> 288b9a8295fb51213e8c2ea94c79e9c386a17eef
=======
>>>>>>> 288b9a8295fb51213e8c2ea94c79e9c386a17eef


var mapperConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new MyApi.Service.Mappers.MappingProfile());
});
IMapper mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);



<<<<<<< HEAD
<<<<<<< HEAD

=======
>>>>>>> 288b9a8295fb51213e8c2ea94c79e9c386a17eef
=======
>>>>>>> 288b9a8295fb51213e8c2ea94c79e9c386a17eef
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
