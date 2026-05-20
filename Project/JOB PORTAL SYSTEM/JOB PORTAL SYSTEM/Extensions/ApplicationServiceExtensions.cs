
using Domain;
using Domain.Data;
using Domain.Data;
using Domain.Helper;
using Domain.Services;
using Domain.Services.Job_Provider;
using Domain.Services.Job_Provider.Candidate;
using Domain.Services.Job_Provider.Candidate.Interface;
using Domain.Services.Job_Provider.CompanyProfile;
using Domain.Services.Job_Provider.CompanyProfile.Interface;
using Domain.Services.Job_Provider.Interviews;
using Domain.Services.Job_Provider.Interviews.Interface;
using Domain.Services.Job_Provider.Job_Service;
using Domain.Services.Job_Provider.ViewCompanyApplications;
using Domain.Services.Job_Provider.ViewCompanyApplications.Interface;
using Domain.Services.Job_Provider.ViewJobs;
using Domain.Services.Job_Provider.ViewJobs.Interface;
using Domain.Services.Job_Seeker.Resume;
using Domain.Services.Job_Seeker.Resume.Interfaces;
using Domain.Services.Jobs;
using Domain.Services.Jobs.Interfaces;
using Domain.Services.JobSeeker.Profile.Interface;
using Domain.Services.JobSeeker.Profile.Repository;
using Domain.Services.JobSeeker.Profile.Service;
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

           
            services.AddScoped<Domain.Services.Auth.Interface.IAuthRepository, Domain.Services.Auth.AuthRepository>();
            services.AddScoped<Domain.Services.Auth.Interface.IAuthService, Domain.Services.Auth.AuthService>();


            services.AddScoped<IJobSeekerProfileService,JobSeekerProfileService>();
            services.AddScoped<IJobSeekerProfileRepository,JobSeekerProfileRepository>();

            services.AddScoped<IEmailService, EmailService>();
            services.AddScoped<IInterviewService, InterviewService>();
            services.AddScoped<IInterviewRepository, InterviewRepository>();


            services.AddScoped<ILocationRepository, LocationRepository>();
            //services.AddScoped<IAdminServices, AdminServices>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserService>();
            //services.AddScoped<IAdminRepositories, AdminRepositories>();
            services.AddScoped<IQualificationRepository, QualificationRepository>();
            services.AddScoped<IQualificationService, QualificationService>();

            services.AddScoped<IResumeRepository, ResumeRepository>();
            services.AddScoped<IResumeService, ResumeService>();



            services.AddScoped<ICompanyRepository, CompanyRepository>();
            services.AddScoped<ICompanyService, CompanyService>();

            services.AddScoped<IJobRepository, JobRepository>();
            services.AddScoped<IJobService, JobService>();



            


            services.AddScoped<Domain.Services.Job_Seeker.Interviews .Interfaces.IInterviewRepository , Domain.Services.Job_Seeker.Interviews .InterviewRepository >();

            services.AddScoped<Domain.Services.Job_Seeker.Interviews.Interfaces.IInterviewService , Domain.Services.Job_Seeker.Interviews .InterviewService >();


            services.AddScoped<Domain.Services.Job_Seeker.Applications.Interfaces.IJobApplicationService,Domain.Services.Job_Seeker.Applications.JobApplicationService>();

            services.AddScoped<Domain.Services.Job_Seeker.Applications.Interfaces.IJobApplicationRepository,Domain.Services.Job_Seeker.Applications.JobApplicationRepository>();

            services.AddScoped<ICandidateService, CandidateService>();
            services .AddScoped <ICandidateRepository , CandidateRepository>();

            services.AddScoped<IViewJobRepository, ViewJobRepository>();
            services.AddScoped<IViewJobService, ViewJobService>();

            services.AddScoped<IApplicationRepository, ApplicationRepository>();
            services .AddScoped <IApplicationService , ApplicationService>();

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.Configure<MailSettings>(configuration.GetSection("MailSettings"));
            services.AddHttpContextAccessor();

            services.AddAutoMapper(typeof(AutoMapperProfiles));

            return services;
        }
    }
}
