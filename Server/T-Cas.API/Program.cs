using T_Cas.Business.Interfaces;
using T_Cas.Business.MappingProfiles;
using T_Cas.Business.Services;
using T_Cas.Data.DataContext;
using T_Cas.Data.Repositories.Implementations;
using T_Cas.Data.Repositories.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddOpenApi();
// TODO: Add database context
//builder.Services.AddDbContext<TCasContext>(
//    dbContextOptions => dbContextOptions.UseSqlite("Data Source=../Todo.Data/Todo.db"));

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserService, UserService>();

// Register AutoMapper
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapControllers();

app.Run();
