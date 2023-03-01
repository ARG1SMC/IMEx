using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using IMExApi.Data;
using IMExApi.Repository.Interfaces;
using IMExApi.Repository.Classes;

var builder = WebApplication.CreateBuilder(args);

//builder.Services.Configure<AppSettings>(builder.Configuration.GetSection("AppSettings"));
//builder.Services.Configure<AppFormatSettings>(builder.Configuration.GetSection("AppFormatSettings"));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddSwaggerGen(c =>
//{
//    c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
//});

builder.Services.AddDbContext<IMExDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("IMExDbConnection")));
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IOPURepository, OPURepository>();
builder.Services.AddScoped<IRoleRepository, RoleRepository>();
builder.Services.AddScoped<IPlatformRepository, PlatformRepository>();
builder.Services.AddScoped<ILocationOneRepository, LocationOneRepository>();
builder.Services.AddScoped<ILocationTwoRepository, LocationTwoRepository>();
builder.Services.AddScoped<IHACDwgNoRepository, HACDwgNoRepository>();
builder.Services.AddScoped<ICoordinateRepository, CoordinateRepository>();
builder.Services.AddScoped<IZoneRepository, ZoneRepository>();
builder.Services.AddScoped<IPurposeRepository, PurposeRepository>();
builder.Services.AddScoped<IManufacturerRepository, ManufacturerRepository>();
builder.Services.AddScoped<IModelRepository, ModelRepository>();
builder.Services.AddScoped<ISerialNoRepository, SerialNoRepository>();
builder.Services.AddScoped<IIECExCertificateAuthorityRepository, IECExCertificateAuthorityRepository>();
builder.Services.AddScoped<IIECExCertificateCategoryRepository, IECExCertificateCategoryRepository>();
builder.Services.AddScoped<IIECExCertificateNoRepository, IECExCertificateNoRepository>();
builder.Services.AddScoped<IIECExCertificateDetailRepository, IECExCertificateDetailRepository>();
builder.Services.AddScoped<IElectricalRatingRepository, ElectricalRatingRepository>();
builder.Services.AddScoped<IDisciplineRepository, DisciplineRepository>();
builder.Services.AddScoped<IProtectionTypeRepository, ProtectionTypeRepository>();
builder.Services.AddScoped<IEquipmentRepository, EquipmentRepository>();
builder.Services.AddScoped<IInspectionRepository, InspectionRepository>();
builder.Services.AddScoped<IInspectionTypeRepository, InspectionTypeRepository>();

builder.Services.AddCors((setup) =>
{
    setup.AddPolicy("default", (option) =>
    {
        option.AllowAnyMethod().AllowAnyHeader().AllowAnyOrigin();
    });
});

var app = builder.Build();

app.UseSwagger();

if (app.Environment.IsDevelopment())
{
    app.UseSwaggerUI();
}

app.UseCors("default");
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
