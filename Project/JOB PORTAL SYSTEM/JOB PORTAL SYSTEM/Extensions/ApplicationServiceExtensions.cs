using Domain.Data;

using Domain.Member.Interface;
using Domain.Member.Repository;
using Domain.Member.Service;
using AutoMapper;
using Domain.Services.Admin.CompanyVerification;
using Domain.Services.Admin.CompanyVerification.Interface;
using Domain.Services.Admin.Skills;
using Domain.Services.Admin.Skills.Interfaces;
using Domain.Services.Job_Provider;
using Domain.Services.Job_Provider.CompanyProfile;
using Domain.Services.Job_Provider.CompanyProfile.Interface;
using Domain.Services.Job_Provider.Job_Service;

using Microsoft.EntityFrameworkCore;
using Domain.Services.Jobs.Interfaces;
using Domain.Services.Jobs;
using Domain.Services.Job_Provider.Signup.Interface;
using Domain.Services.Job_Provider.AuthUser.Interface;
using Domain.Services.Job_Provider.Signup;
using Domain.Services.Job_Provider.AuthUser;
using Domain.Services.Job_Provider.Login.Interface;
using Domain.Services.Job_Provider.Login;
using Domain.Services.Job_Seeker.Login.Interface;
using Domain.Services.Job_Seeker.Login;
using Domain;
using Domain.Helper;

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

            
            services.AddScoped<IJobsRepository, JobsRepository>();
            services.AddScoped<IJobsService, JobsService>();

            services.AddScoped<IAdminRepository, AdminRepository>();
            services.AddScoped<IAdminService, AdminService>();

            services.AddScoped<ISkillRepository, SkillRepository>();
            services.AddScoped<ISkillService, SkillService>();


            services.AddScoped<ICompanyRepository, CompanyRepository>();
            services.AddScoped<ICompanyService, CompanyService>();

            services.AddScoped<IJobRepository, JobRepository>();
            services.AddScoped<IJobService, JobService>();

            services.AddScoped<ISignUpRequestService, SignUpRequestService>();

            services.AddScoped<IAuthUserRepository, AuthUserRepository>();
            services.AddScoped<ISignUpRequestRepository, SignUpRequestRepository>();

            services.AddScoped<Domain.Services.Job_Provider.Login.Interface.ILoginRequestRepository, Domain.Services.Job_Provider.Login.LoginRequestRepository>();
            services.AddScoped<ILoginRequestServices, LoginRequestServices>();



            services.AddScoped<IAuthUserRepository, AuthUserRepository>();
            
            services.AddScoped<ISignUpRequestRepository, SignUpRequestRepository>();
            services.AddScoped<ISignUpRequestService, SignUpRequestService>();
            services.AddScoped<Domain.Services.Job_Seeker.Login.Interface.ILoginRequestRepository, Domain.Services.Job_Seeker.Login.LoginRequestRepository>();
            services.AddScoped<ILoginRequestService, LoginRequestService>();
            services.AddScoped<IEmailService, EmailService>();

            services.AddAutoMapper(map => map.AddProfile(new UseProfileMapping()));
           // services.Configure<Mailsettings>(configuration.GetSection("MailSettings"));
            //services.AddHttpContextAccessor();
            //services.AddAutoMapper(map => map.AddProfile(new AutoMapperProfiles()));
            services.AddAutoMapper(typeof(AutoMapperProfiles).Assembly);
            services.Configure<MailSettings>(configuration.GetSection("MailSettings"));
            services.AddHttpContextAccessor();

            return services;
        }
    }
}
