using Exercise_OOP.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_OOP.Models
{
    internal class JobSeeker
    {
        
        public int Id {  get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email {  get; set; }
        public string Phone {  get; set; }
        public string Location { get; set; }
        public string AboutMe { get; set; }
        public string Qualification { get; set; }
        public ExperienceLevels experience { get; set; }  
        public string Password { get; set; }




        public JobSeeker(int Id,string FirstName,string LastName,string Email,string Phone,string Location, string AboutME,string Qualification,ExperienceLevels experience,string password) 
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.Phone = Phone;
            this.Location = Location;
            this.AboutMe = AboutME;
            this.Qualification = Qualification;
            this.experience = experience;
            this.Password = password;
        }

        public Job[] appliedjobs = new Job[10];
        public int appliedjobCount = 0;


        public void AddAppliedJob(Job job)
        { 
            if(appliedjobCount >= appliedjobs.Length)
            {
                Console.WriteLine("Applied jobs are full !!");
                return;
            }

            appliedjobs[appliedjobCount] = job; 
            appliedjobCount++;
            
        }
        public Job[] GetAppliedJobs()
        {
            return appliedjobs;
        }


        public Job[] savedjobs = new Job[10];
        public int savedjobCount = 0;

        public void addSavedJob(Job job) 
        {
            if(savedjobCount >= savedjobs.Length) 
            {
                Console.WriteLine("Saved jobs are full !!");
                return;
            }

            savedjobs[savedjobCount] = job;
            savedjobCount++;    
        }
        public Job[] GetSavedJobs() 
        {
            return savedjobs ;
        }


    }
}
