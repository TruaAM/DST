import { Component } from '@angular/core';
import { GreetingComponent } from './components/greeting/greeting.component';
import { QuoteComponent } from './components/quote/quote.component';
import { SocialButtonsComponent } from './components/social-buttons/social-buttons.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [GreetingComponent, QuoteComponent, SocialButtonsComponent],
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent { }
