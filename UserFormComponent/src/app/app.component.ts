import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';

import { UserFormDetails } from './Models/userform.model';
import { UserformcomponentService } from './service/userformcomponent.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
 

  constructor(public service:UserformcomponentService)
  {

  }
  ngOnInit(): void {
    
  }
  onSubmit(form:NgForm){
 this.service.postUserFormDetails().subscribe(
  res=>{

  },
  err =>{console.log(err);}
)
  }
 
  }
  

