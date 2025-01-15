import { Component, ViewChild } from '@angular/core';

@Component({
  selector: 'app-movie-container',
  templateUrl: './movie-container.component.html',
  styleUrl: './movie-container.component.css'
})
export class MovieContainerComponent {

  @ViewChild('movieList') movieList: any;

  handleSearch(title?: string): void{
    if(title){
      this.movieList.getMoviesByTitle(title);
    } else {
      this.movieList.getAllMovies();
    }
    
  }

}
