import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { UserFormDetails } from '../Models/userform.model';

@Injectable({
  providedIn: 'root'
})
export class UserformcomponentService {
  baseUrl='http://localhost:6386/api/UserFormDetails/adduser';



  constructor(private http:HttpClient)
   { 

  }
  formData:UserFormDetails=new UserFormDetails();
  postUserFormDetails(){
   return this.http.post(this.baseUrl,this.formData);
  }

 
}
