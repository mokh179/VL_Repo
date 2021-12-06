import { Injectable } from '@angular/core';
import { Request } from './../Vmodels/request';
import { HttpClient } from '@angular/common/http';
@Injectable({
  providedIn: 'root'
})
export class BaseService {
  constructor(private http:HttpClient) { }
  GetAll(){
    return this.http.get<Request[]>('https://localhost:44382/api/Requests')
  }
}
