import { Component, Input, OnChanges, SimpleChanges } from '@angular/core';

@Component({
  selector: 'app-content',
  templateUrl: './content.component.html',
  styleUrls: ['./content.component.css']
})
export class ContentComponent implements OnChanges {

  @Input()
  searchText: string = '';

  selectedFilter: string = 'All';

  allRegistrations = [

    {
      id: '#APL-0003',
      dateApplied: 'June 1, 2020, 08:22 AM',
      company: 'Mosciski Inc.',
      image: 'assets/images/company.png',
      department: 'Creative Design Agency',
      type: 'Freelance',
      position: 'Intern UI Designer',
      status: 'Pending'
    },

    {
      id: '#APL-0004',
      dateApplied: 'June 1, 2020, 08:22 AM',
      company: 'Amazon Inc.',
      image: 'assets/images/company.png',
      department: 'E-Commerce',
      type: 'Fulltime',
      position: 'Intern UI Designer',
      status: 'On Hold'
    },

    {
      id: '#APL-0005',
      dateApplied: 'June 1, 2020, 08:22 AM',
      company: 'Flipkart Inc.',
      image: 'assets/images/company.png',
      department: 'E-Commerce',
      type: 'Fulltime',
      position: 'Intern UI Designer',
      status: 'Candidate'
    },

    {
      id: '#APL-0006',
      dateApplied: 'June 1, 2020, 08:22 AM',
      company: 'Myntra Inc.',
      image: 'assets/images/company.png',
      department: 'E-Commerce',
      type: 'Fulltime',
      position: 'Intern UI Designer',
      status: 'Candidate'
    },

    {
      id: '#APL-0007',
      dateApplied: 'June 1, 2020, 08:22 AM',
      company: 'Mosciski Inc.',
      image: 'assets/images/company.png',
      department: 'Creative Design Agency',
      type: 'FREELANCE',
      position: 'Intern UI Designer',
      status: 'Pending'
    },

    {
      id: '#APL-0008',
      dateApplied: 'June 1, 2020, 08:22 AM',
      company: 'Reliance Inc.',
      image: 'assets/images/company.png',
      department: 'IT',
      type: 'Fulltime',
      position: 'Intern UI Designer',
      status: 'Candidate'
    },

    {
      id: '#APL-0009',
      dateApplied: 'June 1, 2020, 08:22 AM',
      company: 'Mosciski Inc.',
      image: 'assets/images/company.png',
      department: 'Creative Design Agency',
      type: 'FREELANCE',
      position: 'Intern UI Designer',
      status: 'On Hold'
    }

  ];

  registrations = [...this.allRegistrations];

  filterRegistrations(status: string): void {
    this.selectedFilter = status;
    this.applyFilters();
  }

  ngOnChanges(changes: SimpleChanges): void {
    if (changes['searchText']) {
      this.applyFilters();
    }
  }

  applyFilters(): void {

    this.registrations = this.allRegistrations.filter(reg => {

      const matchesStatus =
        this.selectedFilter === 'All' ||
        reg.status === this.selectedFilter;

      const matchesSearch =
        reg.company.toLowerCase().includes(this.searchText.toLowerCase());

      return matchesStatus && matchesSearch;

    });

  }

}