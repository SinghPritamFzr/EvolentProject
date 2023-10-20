using Evolent.DomainLayer.Data;
using Evolent.DomainLayer.Models;
using Evolent.RepositoryLayer.IRepository;
using Evolent.RepositoryLayer.Repository;
using Evolent.ServiceLayer.ICustomServices;
using ServiceLayer.CustomServices;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//var ConnectionString = builder.Configuration.GetConnectionString("DefaultConnection");
//builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(ConnectionString));
builder.Services.AddDbContext<ApplicationDbContext>();


// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region Service Injected
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<ICustomService<Employee>, EmployeeService>();
#endregion
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
