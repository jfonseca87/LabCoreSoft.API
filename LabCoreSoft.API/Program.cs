using LabCoreSoft.API.Business.Implementations;
using LabCoreSoft.API.Business.Interfaces;
using LabCoreSoft.API.Models;
using LabCoreSoft.API.Repositories.EF_Implementations;
using LabCoreSoft.API.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddDbContext<LabCoreSoftMedicoContext>(conf => 
    conf.UseSqlServer(builder.Configuration.GetConnectionString("LabCoreSoftMedicoConn")));

builder.Services.AddCors(options => options.AddPolicy("local", conf =>
                conf.AllowAnyOrigin()
                    .AllowAnyHeader()
                    .AllowAnyMethod()
));

builder.Services.AddTransient<ICiudadesRepository, CiudadesRepository>();
builder.Services.AddTransient<IDepartametosRepository, DepartametosRepository>();
builder.Services.AddTransient<ITiposDocumentoRepository, TiposDocumentoRepository>();
builder.Services.AddTransient<IPacienteRepository, PacienteRepository>();
builder.Services.AddTransient<ICiudadesBusiness, CiudadesBusiness>();
builder.Services.AddTransient<IDepartamentosBusiness, DepartamentosBusiness>();
builder.Services.AddTransient<ITiposDocumentoBusiness, TiposDocumentoBusiness>();
builder.Services.AddTransient<IPacienteBusiness, PacienteBusiness>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen( options => 
{
    options.SwaggerDoc("v1", new OpenApiInfo { Title = "LabCoreSoft.API", Version = "v1" });
});


builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("local");

app.UseAuthorization();

app.MapControllers();

app.Run();
