import { Component, EventEmitter, Output } from '@angular/core';

@Component({
  selector: 'app-movie-search',
  templateUrl: './movie-search.component.html',
  styleUrl: './movie-search.component.css'
})
export class MovieSearchComponent {

  @Output() searchEvent = new EventEmitter<string>();

  searchTitle: string = '';

  onSearch(): void {
    this.searchEvent.emit(this.searchTitle);
  }
}
