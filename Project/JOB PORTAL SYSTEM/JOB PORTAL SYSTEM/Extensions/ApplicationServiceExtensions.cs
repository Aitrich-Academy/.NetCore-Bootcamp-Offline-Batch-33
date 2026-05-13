using Domain;
using Domain.Data;
using Domain.Helpers;
using Domain.Service;
using Domain.Service.AuthUser;
using Domain.Service.AuthUser.Interface;
using Domain.Service.Login;
using Domain.Service.Login.Interface;
using Domain.Service.SignUp.Interface;
using Domain.Services.Job_Provider;
using Domain.Services.Job_Provider.CompanyProfile;
using Domain.Services.Job_Provider.CompanyProfile.Interface;
using Domain.Services.Job_Provider.Job_Service;
using Domain.Services.Job_Provider.Job_Service.Interface;
using Microsoft.EntityFrameworkCore;

namespace JOB_PORTAL_SYSTEM.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServiceExtension(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<ICompanyRepository, CompanyRepository>();
            services.AddScoped<ICompanyService, CompanyService>();

            services.AddScoped<IJobRepository, JobRepository>();
            services.AddScoped<IJobService, JobService>();






            services.AddScoped<ICompanyRepository, CompanyRepository>();
            services.AddScoped<ICompanyService, CompanyService>();

            services.AddScoped<IJobRepository, JobRepository>();
            services.AddScoped<IJobService, JobService>();

            services.AddScoped<ISignUpRequestService, SignUpRequestService>();

            services.AddScoped<IAuthUserRepository, AuthUserRepository>();
            services.AddScoped<ISignUpRequestRepository, SignUpRequestRepository>();

            services.AddScoped<ILoginRequestRepository, LoginRequestRepository>();
            services.AddScoped<ILoginRequestServices, LoginRequestServices>();

      

            //services.AddScoped<IAuthUserRepository, AuthUserRepository>();
            //services.AddScoped<ISignUpRequestRepository, SignUpRequestRepository>();
            //services.AddScoped<ISignUpRequestService, SignUpRequestService>();
            //services.AddScoped<ILoginRequestRepository, LoginRequestRepository>();
            //services.AddScoped<ILoginRequestService, LoginRequestService>();
            //services.AddScoped<IEmailService, EmailService>();

            services.AddAutoMapper(map => map.AddProfile(new AutoMapperProfiles()));
            services.Configure<MailSettings>(configuration.GetSection("MailSettings"));
            services.AddHttpContextAccessor();

            return services;
        }
    }
}
