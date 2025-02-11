import { Component } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { HomeService } from './home.service'


@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {

  constructor(private homeservice: HomeService) {

  }

 
  get(): void {
    this.homeservice.get().subscribe(
      (data: any[]) => {
      },
      (error) => {
        console.error(error);
      }
    );
  }
}


