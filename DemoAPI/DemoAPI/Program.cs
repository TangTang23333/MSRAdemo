using Core.RepoInterface;
using Core.ServiceInterface;
using Infrastructure.Repository;
using Infrastructure.Service;

var builder = WebApplication.CreateBuilder(args);

// register services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// inject dbcontext if has one, no need if using mock data 
// dependency injection 
builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddScoped<IEmployeeService, EmployeeService>();
// configure the app's request pipeline 
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();

// is a must, otherwise, the frontend will not be able to make http request.
app.UseCors(policy =>

{
    policy.WithOrigins(
      builder.Configuration["angularFrontEnd"])
      .AllowAnyHeader()
      .AllowAnyMethod();
}
);
app.MapControllers();
app.Run();