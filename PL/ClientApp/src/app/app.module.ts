import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';

import { GreetingComponent } from './components/greeting/greeting.component';
import { QuoteComponent } from './components/quote/quote.component';
import { SocialButtonsComponent } from './components/social-buttons/social-buttons.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    GreetingComponent,
    QuoteComponent,
    SocialButtonsComponent
   
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
