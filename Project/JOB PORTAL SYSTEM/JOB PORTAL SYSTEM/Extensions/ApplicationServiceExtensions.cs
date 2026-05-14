using Domain.Data;
using Domain.Services.Job_Provider.Interviews;
using Domain.Services.Job_Provider.Interviews.Interface;
using Domain.Helper;

using Domain.Services.Job_Provider.CompanyProfile;
using Domain.Services.Job_Provider.CompanyProfile.Interface;
using Domain.Services.Job_Provider.Job_Service;
using Domain.Services.Job_Provider.Job_Service.Interface;

using Domain.Services.Job_Seeker.Login;
using Domain.Services.Job_Seeker.Login.Interface;


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

            services.AddScoped<Domain.Services.Job_Seeker.SignUp.Interface.ISignUpRequestRepository, Domain.Services.Job_Seeker.SignUp.SignUpRequestRepository>();
            services.AddScoped<Domain.Services.Job_Seeker.SignUp.Interface.ISignUpRequestService, Domain.Services.Job_Seeker.SignUp.SignUpRequestService>();
            services.AddScoped<Domain.Services.Job_Seeker.AuthUser.Interface.IAuthUserRepository, Domain.Services.Job_Seeker.AuthUser.AuthUserRepository>();
            services.AddScoped<Domain.Services.Job_Seeker.Login.Interface.ILoginRequestRepository, Domain.Services.Job_Seeker.Login.LoginRequestRepository>();
            services.AddScoped<Domain.Services.Job_Seeker.Login.Interface.ILoginRequestServices, Domain.Services.Job_Seeker.Login.LoginRequestServices>();
            services.AddScoped<Domain.IEmailService, Domain.EmailService>();
            services.AddScoped<IInterviewService, InterviewService>();
            services.AddScoped<IInterviewRepository, InterviewRepository>();


            services.AddScoped<ICompanyRepository, CompanyRepository>();
            services.AddScoped<ICompanyService, CompanyService>();

            services.AddScoped<Domain.Services.Job_Seeker.Jobs.Interfaces.IJobRepository, Domain.Services.Job_Seeker.Jobs.JobRepository>();
            services.AddScoped<Domain.Services.Job_Seeker.Jobs.Interfaces.IJobService, Domain.Services.Job_Seeker.Jobs.JobService>();


            services.AddScoped<Domain.Services.Job_Seeker.SignUp.Interface.ISignUpRequestService, Domain.Services.Job_Seeker.SignUp.SignUpRequestService>();

            services.AddScoped<Domain.Services.Job_Seeker.SignUp.Interface.ISignUpRequestRepository, Domain.Services.Job_Seeker.SignUp.SignUpRequestRepository>();

            services.AddScoped<ILoginRequestServices, LoginRequestServices>();

            services.AddScoped<Domain.Services.Job_Provider.AuthUser.Interface.IAuthUserRepository, Domain.Services.Job_Provider.AuthUser.AuthUserRepository>();
            services.AddScoped<Domain.Services.Job_Provider.Signup.Interface.ISignUpRequestRepository, Domain.Services.Job_Provider.Signup.SignUpRequestRepository>();
            services.AddScoped<Domain.Services.Job_Provider.Signup.Interface.ISignUpRequestService, Domain.Services.Job_Provider.Signup.SignUpRequestService>();
            services.AddScoped<Domain.Services.Job_Provider.Login.Interface.ILoginRequestRepository, Domain.Services.Job_Provider.Login.LoginRequestRepository>();
            services.AddScoped<Domain.Services.Job_Provider.Login.Interface.ILoginRequestService, Domain.Services.Job_Provider.Login.LoginRequestService>();

            services.AddScoped<Domain.Services.Job_Seeker.Interviews.Interfaces.IInterviewRepository, Domain.Services.Job_Seeker.Interviews.InterviewRepository>();

            services.AddScoped<Domain.Services.Job_Seeker.Interviews.Interfaces.IInterviewService, Domain.Services.Job_Seeker.Interviews.InterviewService>();


            services.AddScoped<Domain.Services.Job_Seeker.Applications.Interfaces.IJobApplicationService, Domain.Services.Job_Seeker.Applications.JobApplicationService>();

            services.AddScoped<Domain.Services.Job_Seeker.Applications.Interfaces.IJobApplicationRepository, Domain.Services.Job_Seeker.Applications.JobApplicationRepository>();

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.Configure<MailSettings>(configuration.GetSection("MailSettings"));
            services.AddHttpContextAccessor();

            return services;
        }
    }
}
