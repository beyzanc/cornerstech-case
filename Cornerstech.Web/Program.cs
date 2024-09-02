using Cornerstech.BusinessLayer.Abstract;
using Cornerstech.BusinessLayer.Concrete;
using Cornerstech.DataAccessLayer.Abstract;
using Cornerstech.DataAccessLayer.EntityFramework;
using Cornerstech.DataAccessLayer.UnitOfWork.Abstract;
using Cornerstech.DataAccessLayer.UnitOfWork.Concrete;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IUnitOfWorkDal, UnitOfWorkDal>();
builder.Services.AddScoped<IAgreementService, AgreementManager>();
builder.Services.AddScoped<IAgreementPartnerService, AgreementPartnerManager>();
builder.Services.AddScoped<IAgreementRiskService, AgreementRiskManager>();
builder.Services.AddScoped<IAgreementSubjectService, AgreementSubjectManager>();
builder.Services.AddScoped<IPartnerService, PartnerManager>();
builder.Services.AddScoped<IRiskService, RiskManager>();
builder.Services.AddScoped<ISubjectOfWorkService, SubjectOfWorkManager>();
builder.Services.AddScoped<ISubjectRiskService, SubjectRiskManager>();
builder.Services.AddScoped<IUserService, UserManager>();
builder.Services.AddScoped<IRiskManagementService, RiskManagementManager>();


builder.Services.AddScoped<IAgreementDal, EFAgreementDal>();
builder.Services.AddScoped<IAgreementPartnerDal, EFAgreementPartnerDal>();
builder.Services.AddScoped<IAgreementRiskDal, EFAgreementRiskDal>();
builder.Services.AddScoped<IAgreementSubjectDal, EFAgreementSubjectDal>();
builder.Services.AddScoped<IPartnerDal, EFPartnerDal>();
builder.Services.AddScoped<IRiskDal, EFRiskDal>();
builder.Services.AddScoped<ISubjectOfWorkDal, EFSubjectOfWorkDal>();
builder.Services.AddScoped<ISubjectRiskDal, EFSubjectRiskDal>();
builder.Services.AddScoped<IUserDal, EFUserDal>();
builder.Services.AddScoped<IRiskManagementDal, EFRiskManagementDal>();

//builder.Services.AddAutoMapper(typeof(Program).Assembly, typeof(MappingProfile).Assembly);

var app = builder.Build();

// Middleware configuration
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
