using Domain.Data;
using Domain.Helper;
using Domain.Services;
using Domain.Services.Admin.CompanyVerification;
using Domain.Services.Admin.CompanyVerification.Interface;
using Domain.Services.Admin.Interface;
using Domain.Services.Admin.Repository;
using Domain.Services.Admin.Services;
using Domain.Services.Auth;
using Domain.Services.Auth.Interface;
using Domain.Services.Job_Provider.CompanyProfile;
using Domain.Services.Job_Provider.CompanyProfile.Interface;
using Domain.Services.Job_Provider.Interviews;
using Domain.Services.Job_Provider.Interviews.Interface;
using Domain.Services.JobSeeker.Profile.Interface;
using Domain.Services.JobSeeker.Profile.Repository;
using Domain.Services.JobSeeker.Profile.Service;
using Domain.Services.Jobs;
using Domain.Services.Jobs.Interfaces;
using Domain.Services.Member.Interface;
using Domain.Services.Member.Repository;
using Domain.Services.Member.Service;
using Microsoft.EntityFrameworkCore;

namespace JOB_PORTAL_SYSTEM.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServiceExtension(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            // DbContext

            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnection"),
                    x => x.CommandTimeout(300)));



            // AutoMapper

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());



            // HttpContext

            services.AddHttpContextAccessor();



            // Mail Settings

            services.Configure<MailSettings>(
                configuration.GetSection("MailSettings"));



            // Auth

            services.AddScoped<IAuthRepository, AuthRepository>();
            services.AddScoped<IAuthService, AuthService>();



            // Jobs

            services.AddScoped<IJobRepository, JobRepository>();
            services.AddScoped<IJobService, JobService>();

            services.AddScoped<IJobsRepository, JobsRepository>();
            services.AddScoped<IJobsService, JobsService>();



            // Company

            services.AddScoped<ICompanyRepository, CompanyRepository>();
            services.AddScoped<ICompanyService, CompanyService>();



            // Interview - Job Provider

            services.AddScoped<IInterviewRepository, InterviewRepository>();
            services.AddScoped<IInterviewService, InterviewService>();



            // Interview - Job Seeker

            services.AddScoped<
                Domain.Services.Job_Seeker.Interviews.Interfaces.IInterviewRepository,
                Domain.Services.Job_Seeker.Interviews.InterviewRepository>();

            services.AddScoped<
                Domain.Services.Job_Seeker.Interviews.Interfaces.IInterviewService,
                Domain.Services.Job_Seeker.Interviews.InterviewService>();



            // Job Applications

            services.AddScoped<
                Domain.Services.Job_Seeker.Applications.Interfaces.IJobApplicationRepository,
                Domain.Services.Job_Seeker.Applications.JobApplicationRepository>();

            services.AddScoped<
                Domain.Services.Job_Seeker.Applications.Interfaces.IJobApplicationService,
                Domain.Services.Job_Seeker.Applications.JobApplicationService>();



            // Job Seeker Profile

            services.AddScoped<IJobSeekerProfileRepository,
                JobSeekerProfileRepository>();

            services.AddScoped<IJobSeekerProfileService,
                JobSeekerProfileService>();



            // Skills

            services.AddScoped<ISkillRepository, SkillRepository>();
            services.AddScoped<ISkillService, SkillService>();



            // Members

            services.AddScoped<IMemberRepository, MemberRepository>();
            services.AddScoped<IMemberService, CompanyMemberService>();

            services.AddScoped<IApplicationRepository, ApplicationRepository>();
            services.AddScoped<IApplicationservice, ApplicationService>();



            // Email

            services.AddScoped<IEmailService, EmailService>();



            // Company Verification Admin

            services.AddScoped<
                Domain.Services.Admin.CompanyVerification.Interface.IAdminRepository,
                Domain.Services.Admin.CompanyVerification.AdminRepository>();



            // Main Admin

            services.AddScoped<IAdminRepositories, AdminRepositories>();
            services.AddScoped<IAdminServices, AdminServices>();

            services.AddScoped<IAdminRepository, AdminRepository>();
            services.AddScoped<IAdminService, AdminService>();



            // User Management

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserService>();



            // Location

            services.AddScoped<ILocationRepository, LocationRepository>();



            // Qualification

            services.AddScoped<IQualificationRepository,
                QualificationRepository>();

            services.AddScoped<IQualificationService,
                QualificationService>();



            return services;
        }
    }
}