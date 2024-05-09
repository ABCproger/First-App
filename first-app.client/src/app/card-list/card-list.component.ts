import { Component, HostListener, ElementRef } from '@angular/core';
import { CardListService } from '../services/card-list.service';

@Component({
  selector: 'app-card-list',
  templateUrl: './card-list.component.html',
  styleUrl: './card-list.component.css',
})
export class CardListComponent {
  status: boolean = true;
  cards: any = [];

  constructor(private eRef: ElementRef, private cardListService : CardListService) { }

  editStatus: boolean = false;
  clickEvent() {
    this.editStatus = !this.editStatus;
  }

  @HostListener('document:click', ['$event'])
  clickout(event:any) {
    if (!this.eRef.nativeElement.contains(event.target) && this.editStatus) {
      console.log('clicked outside');
      this.editStatus = false;
    } 
  }
  fetchCards(){
    this.cards = this.cardListService.getCardListCards(21)
    console.log(this.cards);
  }
  editEvent() {
    this.editStatus = false;
  }
  editTableName() {
    this.status = !this.status;
    this.editStatus = false;
  }


}
