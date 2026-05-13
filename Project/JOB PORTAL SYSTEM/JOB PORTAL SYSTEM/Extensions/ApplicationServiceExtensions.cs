<<<<<<< HEAD
﻿using Domain.Data;
using Domain.Interviews;
using Domain.Interviews.Interface;
using Domain.Services;
using Domain.Services.AuthUser;
using Domain.Services.AuthUser.Interface;
=======
﻿using Domain;
using Domain.Data;
using Domain.Helpers;
using Domain.Services.Job_Provider;
>>>>>>> 3095fad8d7b73eedcdf894a5d944781877b9fd28
using Domain.Services.Job_Provider.CompanyProfile;
using Domain.Services.Job_Provider.CompanyProfile.Interface;
using Domain.Services.Job_Provider.Job_Service;
using Domain.Services.Job_Provider.Job_Service.Interface;
<<<<<<< HEAD
=======
<<<<<<< HEAD
using Domain.Services.Login;
using Domain.Services.Login.Interface;
using Domain.Services.Signup;
using Domain.Services.Signup.Interface;
=======
>>>>>>> d368a2d9021872ac3c7470e4c0208f4720a40b51
using Domain.Services.Job_Seeker.AuthUser;
using Domain.Services.Job_Seeker.AuthUser.Interface;
using Domain.Services.Job_Seeker.Login;
using Domain.Services.Job_Seeker.Login.Interface;
using Domain.Services.Job_Seeker.SignUp;
using Domain.Services.Job_Seeker.SignUp.Interface;
<<<<<<< HEAD
=======
>>>>>>> 3095fad8d7b73eedcdf894a5d944781877b9fd28
>>>>>>> d368a2d9021872ac3c7470e4c0208f4720a40b51
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

<<<<<<< HEAD
            services.AddScoped<ISignUpRequestRepository, SignUpRequestRepository>();
            services.AddScoped<ISignUpRequestService, SignUpRequestService>();
            services.AddScoped<IAuthUserRepository, AuthUserRepository>();
            services.AddScoped<ILoginRequestRepository, LoginRequestRepository>();
            services.AddScoped<ILoginRequestService, LoginRequestService>();
            services.AddScoped<IEmailService, EmailService>();
            services.AddScoped<IInterviewService, InterviewService>();
            services.AddScoped<IInterviewRepository, InterviewRepository>();
=======

            services.AddScoped<ICompanyRepository, CompanyRepository>();
            services.AddScoped<ICompanyService, CompanyService>();

            services.AddScoped<Domain.Services.Job_Seeker.Jobs.Interfaces.IJobRepository, Domain.Services.Job_Seeker.Jobs.JobRepository>();
            services.AddScoped<Domain.Services.Job_Seeker.Jobs.Interfaces.IJobService, Domain.Services.Job_Seeker.Jobs.JobService>();



            services.AddScoped<ISignUpRequestService, SignUpRequestService>();

            services.AddScoped<IAuthUserRepository, AuthUserRepository>();
            services.AddScoped<ISignUpRequestRepository, SignUpRequestRepository>();

            services.AddScoped<ILoginRequestRepository, LoginRequestRepository>();
            services.AddScoped<ILoginRequestServices, LoginRequestServices>();



            services.AddScoped<IAuthUserRepository, AuthUserRepository>();
            services.AddScoped<ISignUpRequestRepository, SignUpRequestRepository>();
            services.AddScoped<ISignUpRequestService, SignUpRequestService>();
            services.AddScoped<ILoginRequestRepository, LoginRequestRepository>();
            //services.AddScoped<ILoginRequestService, LoginRequestService>();
            services.AddScoped<IEmailService, EmailService>();
>>>>>>> 3095fad8d7b73eedcdf894a5d944781877b9fd28

            services.AddAutoMapper(map => map.AddProfile(new UseProfileMapping()));
            services.Configure<MailSettings>(configuration.GetSection("MailSettings"));
            services.AddHttpContextAccessor();

            return services;
        }
    }
}
