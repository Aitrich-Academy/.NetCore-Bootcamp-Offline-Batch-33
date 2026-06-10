export class Job {
    jobs = [
        {
            title: 'Juniour Process Associate',
            companyName: 'Aitrich Technologies',
            description: 'Product designer responsibilities include defining product specifications, creating digital or print drawing and desinging fully-functional products',
            location: 'Indonesia',
            employmentType: 'Full Time',
            experienceLevel: 'Mid Level',
            salaryRange: '$3000 - $5000'
        },
        {
            title: 'Customer Service Executive',
            companyName: 'ciinfosys',
            description: 'Product designer responsibilities include defining product specifications, creating digital or print drawing and desinging fully-functional products',
            location: 'Indonesia',
            employmentType: 'Full Time',
            experienceLevel: 'Mid Level',
            salaryRange: '$3000 - $5000'
        },
        {
            title: 'Customer Service Executive',
            companyName: 'Infotech',
            description: 'Product designer responsibilities include defining product specifications, creating digital or print drawing and desinging fully-functional products',
            location: 'Indonesia',
            employmentType: 'Full Time',
            experienceLevel: 'Mid Level',
            salaryRange: '$3000 - $5000'
        }
    ];
    getAllJobs() {
        this.jobs.map((job) => {
            console.log("");
            console.log(`Job Title : ${job.title}`);
            console.log(`Job Title : ${job.companyName}`);
            console.log(`Description : ${job.description}`);
            console.log(`Salary Range : ${job.salaryRange}`);
            console.log(`Experience Level: ${job.experienceLevel}`);
            console.log("");
            console.log("------------------------------------------------------------------------------------------------------------");
        });
    }
}
