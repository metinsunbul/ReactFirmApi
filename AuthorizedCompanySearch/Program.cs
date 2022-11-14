using AuthorizedCompanySearch.Data;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// Add Cors
builder.Services.AddCors();
builder.Services.AddCors(options =>
     options.AddDefaultPolicy(builder =>
     builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin()));

builder.Services.AddScoped<IFirmRepo, FirmRepo>();
builder.Services.AddScoped<IPersonelRepo, PersonelRepo>();
builder.Services.AddDbContext<FirmDbContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("FirmConnection")
    ));

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors();
//app.UseHttpsRedirection();

//app.UseAuthorization();

app.MapControllers();


// migrate any database changes on startup (includes initial db creation)
using (var scope = app.Services.CreateScope())
{
    var dataContext = scope.ServiceProvider.GetRequiredService<FirmDbContext>();
    dataContext.Database.Migrate();
}


app.Run();
