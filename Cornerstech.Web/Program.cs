using Cornerstech.BusinessLayer.Abstract;
using Cornerstech.BusinessLayer.Concrete;
using Cornerstech.DataAccessLayer.Abstract;
using Cornerstech.DataAccessLayer.EntityFramework;
using Cornerstech.DataAccessLayer.UnitOfWork.Abstract;
using Cornerstech.DataAccessLayer.UnitOfWork.Concrete;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddSignalR();

builder.Services.AddDbContext<Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))); // Configures the application to use SQL Server as the database and pulls the connection string from appsettings.json

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath = "/Home/Login"; 
        options.AccessDeniedPath = "/Account/AccessDenied";
    }); // Sets up cookie-based authentication with custom login and access denied paths


// Registers Unit of Work, services, and repositories for dependency injection to manage business logic and data access

builder.Services.AddScoped<IUnitOfWorkDal, UnitOfWorkDal>();
builder.Services.AddScoped<IAgreementService, AgreementManager>();
builder.Services.AddScoped<IAgreementPartnerService, AgreementPartnerManager>();
builder.Services.AddScoped<IAgreementRiskService, AgreementRiskManager>();
builder.Services.AddScoped<IAgreementSubjectService, AgreementSubjectManager>();
builder.Services.AddScoped<IPartnerService, PartnerManager>();
builder.Services.AddScoped<IRiskService, RiskManager>();
builder.Services.AddScoped<ISubjectOfWorkService, SubjectOfWorkManager>();
builder.Services.AddScoped<IUserService, UserManager>();
builder.Services.AddScoped<IRiskManagementService, RiskManagementManager>();
builder.Services.AddScoped<INotificationService, NotificationManager>();
builder.Services.AddScoped<INotificationApplicationUserService, NotificationApplicationUserManager>();

builder.Services.AddScoped<IAgreementDal, EFAgreementDal>();
builder.Services.AddScoped<IAgreementPartnerDal, EFAgreementPartnerDal>();
builder.Services.AddScoped<IAgreementRiskDal, EFAgreementRiskDal>();
builder.Services.AddScoped<IAgreementSubjectDal, EFAgreementSubjectDal>();
builder.Services.AddScoped<IPartnerDal, EFPartnerDal>();
builder.Services.AddScoped<IRiskDal, EFRiskDal>();
builder.Services.AddScoped<ISubjectOfWorkDal, EFSubjectOfWorkDal>();
builder.Services.AddScoped<IUserDal, EFUserDal>();
builder.Services.AddScoped<IRiskManagementDal, EFRiskManagementDal>();
builder.Services.AddScoped<INotificationDal, EFNotificationDal>();
builder.Services.AddScoped<INotificationApplicationUserDal, EFNotificationApplicationUserDal>();


var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Login}/{id?}");

app.Run();
