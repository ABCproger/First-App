import { Component,OnInit } from '@angular/core';
import { FormBuilder } from '@angular/forms';
import { CardListService } from '../services/card-list.service';

@Component({
  selector: 'app-new-list',
  templateUrl: './new-list.component.html',
  styleUrl: './new-list.component.css'
})
export class NewListComponent {
  constructor(private db: FormBuilder,private cardListService: CardListService){

  }
  status: boolean = true;
  clickEvent() {
    this.status = !this.status;
  }

}
