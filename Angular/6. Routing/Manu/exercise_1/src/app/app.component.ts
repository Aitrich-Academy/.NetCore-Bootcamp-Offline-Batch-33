import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'exercise_1';

  searchText: string = '';

  onSearchChanged(search: string) {
    this.searchText = search;
  }
}
