import { Component, Inject } from '@angular/core';
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';

@Component({
  selector: 'app-users',
  templateUrl: './users.html'
})
export class UsersComponent {
  public users: any[];
  public NewUser: any;

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {
    http.get<any[]>(baseUrl + 'api/SampleData/GetUsers').subscribe(result => {
      this.users = result;
    }, error => console.error(error));
  }
  Add() {
    let headers = new HttpHeaders();
    headers = headers.set("Content-Type", "application/json");
    let httpParams = new HttpParams()
      .append("Name", this.NewUser)
      .append("UserID", "0");
    this.http.post<any>(this.baseUrl + 'api/SampleData/Add', null, { headers: headers, params: httpParams }).subscribe(result => { });
  }
}
