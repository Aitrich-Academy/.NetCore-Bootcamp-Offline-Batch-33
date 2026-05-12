using Domain.Data;

using Domain.Member.Interface;
using Domain.Member.Repository;
using Domain.Member.Service;
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
            services.AddScoped<IMemberRepository, MemberRepository>();
            services.AddScoped<IMemberService, CompanyMemberService>();
            services.AddScoped<IApplicationRepository, ApplicationRepository>();
            services.AddScoped<IApplicationservice,ApplicationService>();

            //services.AddScoped<IJobRepository, JobRepository>();
           // services.AddScoped<IJobService, JobService>();

            //services.AddScoped<IAuthUserRepository, AuthUserRepository>();
            //services.AddScoped<ISignUpRequestRepository, SignUpRequestRepository>();
            //services.AddScoped<ISignUpRequestService, SignUpRequestService>();
            //services.AddScoped<ILoginRequestRepository, LoginRequestRepository>();
            //services.AddScoped<ILoginRequestService, LoginRequestService>();
           // services.AddScoped<IEmailService, EmailService>();

            services.AddAutoMapper(map => map.AddProfile(new UseProfileMapping()));
           // services.Configure<Mailsettings>(configuration.GetSection("MailSettings"));
            //services.AddHttpContextAccessor();

            return services;
        }
    }
}
