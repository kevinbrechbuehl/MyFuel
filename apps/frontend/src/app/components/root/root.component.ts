import { Component } from '@angular/core';
import { HomeApiService } from '@my-fuel/api';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [],
  templateUrl: './root.component.html',
})
export class RootComponent {
  response = '';

  constructor(private readonly homeApiService: HomeApiService) {}

  pingApi() {
    this.homeApiService
      .apiGet()
      .subscribe((response) => (this.response = response));
  }
}
