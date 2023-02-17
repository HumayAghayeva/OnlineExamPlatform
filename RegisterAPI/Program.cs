using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using RegisterAPI.Interfaces;
using RegisterAPI.Models;
using RegisterAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DBConn>(options =>
{
    //The name of the connection string is taken from appsetting.json under ConnectionStrings
     options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConn"), builder =>
       {
           builder.EnableRetryOnFailure(5, TimeSpan.FromSeconds(10), null);
       });
    options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
});
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "AllowOrigin",
        builder =>
        {
            builder.WithOrigins("*")
                                 .AllowAnyHeader()
                                .AllowAnyMethod();
        });
});
builder.Services.AddScoped<IUserService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors();

//with a named pocili
app.UseCors("AllowOrigin");

//Shows UseCors with CorsPolicyBuilder.
app.UseCors(builder =>
{
    builder
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader();
});
app.UseHttpsRedirection();
app.UseDeveloperExceptionPage();
app.UseAuthorization();

app.MapControllers();

app.Run();
