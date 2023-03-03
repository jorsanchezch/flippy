import { Component, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-search-bar',
  templateUrl: './search-bar.component.html',
  styleUrls: ['./search-bar.component.scss']
})
export class SearchBarComponent {
  @Output() search: EventEmitter<string> = new EventEmitter<string>();

  onSearch(event: Event): void {
    console.log('searched');
    const query = (event.target as HTMLInputElement).value;
    this.search.emit(query);
  }
}
