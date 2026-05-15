using Domain;
using Domain.Data;

using AutoMapper;
using Domain.Services.Admin.CompanyVerification;
using Domain.Services.Admin.CompanyVerification.Interface;
using Domain.Services.Admin.Skills;
using Domain.Services.Admin.Skills.Interfaces;
using Domain.Services.Job_Provider;
using Domain.Services.Job_Provider.CompanyProfile;
using Domain.Services.Job_Provider.CompanyProfile.Interface;
using Domain.Services.Job_Provider.Interviews;
using Domain.Services.Job_Provider.Interviews.Interface;
using Domain.Services.Job_Provider.Job_Service;

using Domain.Services.JobSeeker.Profile.Interface;
using Domain.Services.JobSeeker.Profile.Repository;
using Domain.Services.JobSeeker.Profile.Service;
using Microsoft.EntityFrameworkCore;
using Domain.Services.Jobs.Interfaces;
using Domain.Services.Jobs;

using Domain;
using Domain.Helper;
using Microsoft.EntityFrameworkCore.Migrations.Internal;
using Microsoft.Extensions.DependencyInjection;
using Domain.Services.Auth.Interface;
using Domain.Services.Auth;
using Domain.Services;
using Domain.Services.Member.Interface;
using Domain.Services.Member.Repository;
using Domain.Services.Member.Service;

namespace JOB_PORTAL_SYSTEM.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServiceExtension(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(
        configuration.GetConnectionString("DefaultConnection"),
        x => x.CommandTimeout(300)));


            services.AddScoped<IJobRepository, JobRepository>();
            services.AddScoped<IJobService, JobService>();

          
            services.AddScoped<IInterviewService, InterviewService>();
            services.AddScoped<IInterviewRepository, InterviewRepository>();


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


            services.AddScoped<IAuthRepository, AuthRepository>();
          

          






            services.AddScoped<IJobSeekerProfileRepository, JobSeekerProfileRepository>();

            services.AddScoped<IJobSeekerProfileService, JobSeekerProfileService>();



            //services.AddScoped<IAuthUserRepository, AuthUserRepository>();
            //services.AddScoped<ISignUpRequestRepository, SignUpRequestRepository>();
            //services.AddScoped<ISignUpRequestService, SignUpRequestService>();
            //services.AddScoped<ILoginRequestRepository, LoginRequestRepository>();
            //services.AddScoped<ILoginRequestService, LoginRequestService>();
            services.AddScoped<IAuthService, AuthService>();
            
           
            services.AddScoped<IEmailService, EmailService>();

            services.AddScoped<Domain.Services.Jobs.Interfaces.IJobRepository, Domain.Services.Jobs.JobRepository>();
            services.AddScoped<Domain.Services.Jobs.Interfaces.IJobService, Domain.Services.Jobs.JobService>();



            services.AddScoped<Domain.Services.Job_Seeker.Interviews.Interfaces.IInterviewRepository, Domain.Services.Job_Seeker.Interviews.InterviewRepository>();

            services.AddScoped<Domain.Services.Job_Seeker.Interviews.Interfaces.IInterviewService, Domain.Services.Job_Seeker.Interviews.InterviewService>();


            services.AddScoped<Domain.Services.Job_Seeker.Applications.Interfaces.IJobApplicationService, Domain.Services.Job_Seeker.Applications.JobApplicationService>();

            services.AddScoped<Domain.Services.Job_Seeker.Applications.Interfaces.IJobApplicationRepository, Domain.Services.Job_Seeker.Applications.JobApplicationRepository>();


            services.AddScoped<IApplicationRepository, ApplicationRepository>(); 
            services.AddScoped<IMemberRepository, MemberRepository>(); 
            services.AddScoped<IApplicationservice, ApplicationService>(); 
            services.AddScoped<IMemberService, CompanyMemberService>();
            services.Configure<MailSettings>(configuration.GetSection("MailSettings"));
            services.AddHttpContextAccessor();

            //services.AddAutoMapper(map => map.AddProfile(new UseProfileMapping()));
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
