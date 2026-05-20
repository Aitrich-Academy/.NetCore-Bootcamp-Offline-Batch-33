
using Domain;
using Domain.Data;
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
using Domain.Services.Job_Provider.ViewCompanyApplications.Interface;
using Domain.Services.Jobs;
using Domain.Services.Jobs.Interfaces;
using Domain.Services.JobSeeker.Profile.Interface;
using Domain.Services.JobSeeker.Profile.Repository;
using Domain.Services.JobSeeker.Profile.Service;
using Domain.Services.Member.Interface;
using Domain.Services.Member.Repository;
using Domain.Services.Member.Service;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Internal;

namespace JOB_PORTAL_SYSTEM.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServiceExtension(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

           

            services.AddScoped<IJobRepository, JobRepository>();
            services.AddScoped<IJobService, JobService>();


            services.AddScoped<IInterviewService, InterviewService>();
            services.AddScoped<IInterviewRepository, InterviewRepository>();




            //services.AddScoped<IJobsRepository, JobsRepository>();
            //services.AddScoped<IJobsService, JobsService>();


            services.AddScoped<ISkillRepository, SkillRepository>();
            services.AddScoped<ISkillService, SkillService>();

            services.AddScoped<ILocationRepository, LocationRepository>();
            //services.AddScoped<IAdminServices, AdminServices>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserService>();
            //services.AddScoped<IAdminRepositories, AdminRepositories>();
            services.AddScoped<IQualificationRepository, QualificationRepository>();
            services.AddScoped<IQualificationService, QualificationService>();

            services.AddScoped<IAdminService, AdminService>();
            services.AddScoped<IAdminRepository , AdminRepository>();

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


            services.AddScoped<Domain.Services.Member.Interface.IApplicationRepository, ApplicationRepository>();
            services.AddScoped<Domain.Services.Member.Interface.IApplicationservice, Domain.Services.Member.Service.ApplicationService>();

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.Configure<MailSettings>(configuration.GetSection("MailSettings"));
            services.AddHttpContextAccessor();
            services.AddAutoMapper(typeof(AutoMapperProfiles).Assembly);

            services.AddAutoMapper(typeof(AutoMapperProfiles));

            return services;
        }
    }
}
