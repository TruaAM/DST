import { Component } from '@angular/core';

@Component({
  selector: 'app-quote',
  templateUrl: './quote.component.html',
  styleUrls: ['./quote.component.css']
})
export class QuoteComponent {
  quotes: string[] = [
    "Placeholder1",
    "Placeholder2",
    "Placeholder3"
  ];

  quote: string = '';

  constructor() {
    this.quote = this.getRandomQuote();
  }

  getRandomQuote(): string {
    return this.quotes[Math.floor(Math.random() * this.quotes.length)];
  }
}
