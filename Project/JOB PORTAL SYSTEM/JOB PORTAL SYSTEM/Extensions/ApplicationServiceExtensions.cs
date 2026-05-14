
using Domain.Data;
using Domain.Helper;
using Domain.Services;
using Domain.Services.Auth;
using Domain.Services.Auth.Interface;
using Domain.Services.Job_Provider;
using Domain.Services.Auth;
using Domain.Services.Auth.Interface;
using Domain.Services.Auth;
using Domain.Services.Auth.Interface;
using Domain.Services.Job_Provider.CompanyProfile;
using Domain.Services.Job_Provider.CompanyProfile.Interface;


using Microsoft.EntityFrameworkCore;
using Domain.Services.Job_Provider.Interviews.Interface;
using Domain.Services.Job_Provider.Interviews;
using Domain.Services.Jobs.Interfaces;
using Domain.Services.Jobs;

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

            services.AddScoped<IAuthRepository, AuthRepository>();

            services.AddScoped<IAuthService, AuthService>();

            services.AddScoped<IAuthRepository, AuthRepository>();
            services.AddScoped<IEmailService, EmailService>();
            services.AddScoped<IInterviewService, InterviewService>();
            services.AddScoped<IInterviewRepository, InterviewRepository>();

            services.AddScoped<ICompanyRepository, CompanyRepository>();
            services.AddScoped<ICompanyService, CompanyService>();

            services.AddScoped<IJobRepository, JobRepository>();
            services.AddScoped<IJobService, JobService>();


            services.AddScoped<IAuthRepository, AuthRepository>();

            services.AddScoped<IAuthService, AuthService>();

            services.AddScoped<IAuthRepository, AuthRepository>();


            services.AddScoped<IAuthRepository, AuthRepository>();

            services.AddScoped<IAuthService, AuthService>();


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
