import { Component, EventEmitter, Output  } from '@angular/core';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent {

  @Output()
    searchChanged = new EventEmitter<string>();
  
    searchText = '';

    onSearch() {
      this.searchChanged.emit(this.searchText);
    }
}
