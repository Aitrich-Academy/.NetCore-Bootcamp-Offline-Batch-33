using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<AuthUser> AuthUsers { get; set; }
        //public DbSet<SystemUser> SystemUsers { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<CompanyMember> CompanyMembers { get; set; }
        public DbSet<Industry> Industries { get; set; }
        public DbSet<JobSeeker> JobSeekers { get; set; }
        public DbSet<JobSeekerProfile> JobSeekerProfiles { get; set; }
        public DbSet<JobSeekerQualification> JobSeekerQualifications { get; set; }
        public DbSet<Resume> Resumes { get; set; }
        public DbSet<Qualification> Qualifications { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<JobSeekerSkills> JobSeekerSkills { get; set; }
        public DbSet<Interview> Interviews { get; set; }
        public DbSet<SavedJobs> SavedJobs { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<JobApplication> JobApplications { get; set; }
        public DbSet<JobCategory> JobCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // JobApplication → JobSeeker (Cascade)
            modelBuilder.Entity<JobApplication>()
                .HasOne(ja => ja.JobSeeker)
                .WithMany(js => js.Applications)
                .HasForeignKey(ja => ja.JobSeekerId)
                .OnDelete(DeleteBehavior.Cascade);

            // JobApplication → Job (Restrict)
            modelBuilder.Entity<JobApplication>()
                .HasOne(ja => ja.Job)
                .WithMany(j => j.Applications)
                .HasForeignKey(ja => ja.JobId)
                .OnDelete(DeleteBehavior.Restrict);

            // JobApplication → Resume (Restrict)
            modelBuilder.Entity<JobApplication>()
                .HasOne(ja => ja.Resume)
                .WithMany(r => r.JobApplications)
                .HasForeignKey(ja => ja.ResumeId)
                .OnDelete(DeleteBehavior.Restrict);
           // SavedJobs → JobSeeker(Cascade makes sense: if a seeker is deleted, their saved jobs should go too)
            modelBuilder.Entity<SavedJobs>()
                .HasOne(sj => sj.JobSeeker)
                .WithMany(js => js.SavedJobs)
                .HasForeignKey(sj => sj.JobSeekerId)
                .OnDelete(DeleteBehavior.Cascade);

            // SavedJobs → Job (Restrict: don’t auto-delete saved jobs when a job is deleted)
            modelBuilder.Entity<SavedJobs>()
                .HasOne(sj => sj.Job)
                .WithMany(j => j.SavedJobs)
                .HasForeignKey(sj => sj.JobId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Company>()
                .HasOne(c => c.Location)
                .WithMany(l => l.Companies)
                .HasForeignKey(c => c.LocationId)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Job>()
                .HasOne(j => j.Company)
                .WithMany(c => c.Jobs)
                .HasForeignKey(j => j.CompanyId)
                .OnDelete(DeleteBehavior.Restrict);
        }

    }
}
