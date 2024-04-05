using ActuArte.Business;
using ActuArte.Models;
using ActuArte.Data;
using Microsoft.EntityFrameworkCore;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// CONFIG PARA EL LOGGER
Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Information()
    .WriteTo.Console()
    .WriteTo.File("logs/application.log", rollingInterval: RollingInterval.Day)
    .WriteTo.Debug()
    .CreateLogger();
builder.Host.UseSerilog();

// Agrega servicios al contenedor.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();


builder.Services.AddCors(options =>
{
    options.AddPolicy("MyCorsPolicy",
        policy => policy
            .WithOrigins("*") // Permite solicitudes de cualquier origen
            .AllowAnyMethod() // Permite todos los métodos HTTP
            .AllowAnyHeader()); // Permite todas las cabeceras HTTP
});





var keyString = "ServerDB";
var connectionString = builder.Configuration.GetConnectionString(keyString);

builder.Services.AddDbContext<ActuArteContext>(options =>
    options.UseSqlServer(connectionString, sqlServerOptionsAction: sqlOptions =>
    {
        sqlOptions.EnableRetryOnFailure(
            maxRetryCount: 10,
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

builder.Services.AddScoped<CredentialsService>();
builder.Services.AddScoped<ICredentialsRepository, CredentialsRepository>();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You might want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


app.UseSwagger();
app.UseSwaggerUI();


app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapControllers();


// Uso de CORS con la política definida
app.UseCors("MyCorsPolicy");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();