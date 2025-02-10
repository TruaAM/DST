import { Component } from '@angular/core';

@Component({
  selector: 'app-greeting',
  templateUrl: './greeting.component.html',
  styleUrls: ['./greeting.component.css']
})
export class GreetingComponent {
  greeting: string = '';

  constructor() {
    this.setGreeting();
  }

  setGreeting() {
    const hour = new Date().getHours();
    if (hour < 12) {
      this.greeting = 'Good morning!';
    } else if (hour < 18) {
      this.greeting = 'Good afternoon!';
    } else {
      this.greeting = 'Good evening!';
    }
  }
}
