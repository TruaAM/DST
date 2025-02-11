import { HttpClient } from '@angular/common/http';
import { Injectable, Inject } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class HomeService {

  private HttpOptions = {
    headers: {
      'Content-Type': 'application/json',
    },
  };


  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) { }

  get(): Observable<any[]> {

    const baseUrl = this.baseUrl;
    console.log(baseUrl);
    const url = 'https://localhost:7216/api/Home/GET';
    return this.http.get<any[]>(url, this.HttpOptions);
  }
}

