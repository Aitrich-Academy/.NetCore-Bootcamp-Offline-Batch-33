import { Component } from '@angular/core';

@Component({
  selector: 'app-content',
  templateUrl: './content.component.html',
  styleUrls: ['./content.component.css']
})
export class ContentComponent {
  selectedStatus = 'All';
jobs = [
  {
    ID : "#APL-003",
    DateApplied : "June 1, 2020, 08:22 AM",
    Company : "Mocklab Inc",
    jobRole : "Creative Design Agency",
    jobType :  "FREELANCE",
    position : "Intern UI Designer",
    status : "Pending"
  },
  {
    ID : "#APL-003",
    DateApplied : "June 1, 2020, 08:22 AM",
    Company : "Mocklab Inc",
    jobRole : "Creative Design Agency",
    jobType :  "FREELANCE",
    position : "Intern UI Designer",
    status : "On-Hold"
  },
  {
    ID : "#APL-003",
    DateApplied : "June 1, 2020, 08:22 AM",
    Company : "Mocklab Inc",
    jobRole : "Creative Design Agency",
    jobType :  "FREELANCE",
    position : "Intern UI Designer",
    status : "Pending"
  },
  {
    ID : "#APL-003",
    DateApplied : "June 1, 2020, 08:22 AM",
    Company : "Mocklab Inc",
    jobRole : "Creative Design Agency",
    jobType :  "FREELANCE",
    position : "Intern UI Designer",
    status : "Candidate"
  },
  {
    ID : "#APL-003",
    DateApplied : "June 1, 2020, 08:22 AM",
    Company : "Mocklab Inc",
    jobRole : "Creative Design Agency",
    jobType :  "FREELANCE",
    position : "Intern UI Designer",
    status : "On-Hold"
  },
  {
    ID : "#APL-003",
    DateApplied : "June 1, 2020, 08:22 AM",
    Company : "Mocklab Inc",
    jobRole : "Creative Design Agency",
    jobType :  "FREELANCE",
    position : "Intern UI Designer",
    status : "Candidate"
  }
];




filteredJobs(){
  if(this.selectedStatus == 'All'){
    return this.jobs;
  }
  return this.jobs.filter(
      job => job.status === this.selectedStatus
    );
}

filterJobs(status : string){
this.selectedStatus = status;
}


}
