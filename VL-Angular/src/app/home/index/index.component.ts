import { Component, OnInit } from '@angular/core';
import { BaseService } from 'src/app/Service/base.service';
import { Request } from 'src/app/Vmodels/request';
@Component({
  selector: 'app-index',
  templateUrl: './index.component.html',
  styleUrls: ['./index.component.css']
})
export class IndexComponent implements OnInit {

  constructor(private ser:BaseService) { }
  Requests:Request[]=[]
  ngOnInit(): void {
    this.ser.GetAll().subscribe(a=>
      {
        this.Requests=a
        console.log(this.Requests)
      }
      )
  }

}
