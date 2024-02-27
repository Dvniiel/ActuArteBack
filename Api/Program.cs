using ActuArte.Business;
using ActuArte.Models;
using ActuArte.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Agrega servicios al contenedor.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var isRunningInDocker = Environment.GetEnvironmentVariable("DOCKER_CONTAINER") == "true";
var keyString = isRunningInDocker ? "ServerDB_Docker" : "ServerDB_Local";
var connectionString = builder.Configuration.GetConnectionString(keyString);

builder.Services.AddDbContext<ActuArteContext>(options => 
    options.UseSqlServer(connectionString, sqlServerOptionsAction: sqlOptions =>
    {
        sqlOptions.EnableRetryOnFailure(
            maxRetryCount:10,
            maxRetryDelay: TimeSpan.FromSeconds(30),
            errorNumbersToAdd: null);
    }));

builder.Services.AddScoped<ObrasService>();

// OBRAS :(
builder.Services.AddScoped<ObrasService>();
builder.Services.AddScoped<IObrasRepository, ObrasRepository>();

// USUARIOUUS
builder.Services.AddScoped<UsuariosService>();
builder.Services.AddScoped<IUsuariosRepository, UsuariosRepository>();

// ASIENTOUUS
builder.Services.AddScoped<AsientosService>();
builder.Services.AddScoped<IAsientosRepository, AsientosRepository>();



var app = builder.Build();



app.UseSwagger();
app.UseSwaggerUI();


app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();