import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { OnInit } from '@angular/core';
import { Movie } from '../../../Models/Movie';

@Component({
  selector: 'app-movie-list',
  templateUrl: './movie-list.component.html',
  styleUrl: './movie-list.component.css'
})
export class MovieListComponent implements OnInit {

  movies: Movie[] = [];

  constructor(private http: HttpClient){}

  ngOnInit(): void{
    this.getAllMovies();
  }

  stringifyMovies(){
    return JSON.stringify(this.movies)
  }

  getAllMovies(){
    this.http.get<Movie[]>('https://localhost:7193/')
      .subscribe(response => {
        this.movies = response;
      })
  }

  getMoviesByTitle(title: string): void {
    let url = 'https://localhost:7193/'
    url += `s?title=${title}`

    this.http.get<Movie[]>(url)
      .subscribe(response => {
        this.movies = response;
      });    
  }

}
