
using Domain;
using Domain.Data;
using Domain.Data;
using Domain.Helper;
using Domain.Services;
using Domain.Services.Auth;
using Domain.Services.Auth.Interface;
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
using Domain.Services.Jobs;
using Domain.Services.Jobs.Interfaces;



using Microsoft.EntityFrameworkCore;

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

            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IAuthRepository, AuthRepository>();


            services.AddScoped<Domain.Services.IEmailService, Domain.Services.EmailService>();
            services.AddScoped<IInterviewService, InterviewService>();
            services.AddScoped<IInterviewRepository, InterviewRepository>();


            services.AddScoped<ICompanyRepository, CompanyRepository>();
            services.AddScoped<ICompanyService, CompanyService>();

            


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
            services.AddAutoMapper(typeof(AutoMapperProfiles).Assembly);

            return services;
        }
    }
}
