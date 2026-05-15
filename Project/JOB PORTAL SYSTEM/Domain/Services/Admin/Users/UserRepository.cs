using Domain.Data;
using Domain.Services.Admin.Users.Dto;
using Domain.Services.Admin.Users.Interface;
using Microsoft.EntityFrameworkCore;

namespace Domain.Services.Admin.Users
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<UserResponseDto>>
            GetAllUsersAsync()
        {
            try
            {
                // JobSeekers

                var jobSeekers =
                    await _context.JobSeekers

                    .Include(x => x.AuthUser)

                    .Select(x => new UserResponseDto
                    {
                        Id = x.Id,

                        FullName =
                            x.AuthUser.FirstName + " " +
                            x.AuthUser.LastName,

                        Email = x.AuthUser.Email,

                        PhoneNumber =
                            x.AuthUser.PhoneNumber,

                        Role = "JobSeeker"
                    })

                    .ToListAsync();

                // JobProviders

                var jobProviders =
                    await _context.JobProviders

                    .Select(x => new UserResponseDto
                    {
                        Id = x.Id,

                        FullName =
                            x.FirstName + " " +
                            x.LastName,

                        Email = "",

                        PhoneNumber = "",

                        Role = "JobProvider"
                    })

                    .ToListAsync();

                return jobSeekers
                    .Concat(jobProviders)
                    .ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(
                    $"Error while fetching users : {ex.Message}");
            }
        }

        public async Task<UserResponseDto?>
            GetUserByIdAsync(Guid id)
        {
            try
            {
                // JobSeeker

                var jobSeeker =
                    await _context.JobSeekers

                    .Include(x => x.AuthUser)

                    .Where(x => x.Id == id)

                    .Select(x => new UserResponseDto
                    {
                        Id = x.Id,

                        FullName =
                            x.AuthUser.FirstName + " " +
                            x.AuthUser.LastName,

                        Email = x.AuthUser.Email,

                        PhoneNumber =
                            x.AuthUser.PhoneNumber,

                        Role = "JobSeeker"
                    })

                    .FirstOrDefaultAsync();

                if (jobSeeker != null)
                {
                    return jobSeeker;
                }

                // JobProvider

                var jobProvider =
                    await _context.JobProviders

                    .Where(x => x.Id == id)

                    .Select(x => new UserResponseDto
                    {
                        Id = x.Id,

                        FullName =
                            x.FirstName + " " +
                            x.LastName,

                        Email = "",

                        PhoneNumber = "",

                        Role = "JobProvider"
                    })

                    .FirstOrDefaultAsync();

                return jobProvider;
            }
            catch (Exception ex)
            {
                throw new Exception(
                    $"Error while fetching user by id : {ex.Message}");
            }
        }
    }
}