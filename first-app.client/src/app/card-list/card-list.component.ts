import { Component, HostListener, ElementRef } from '@angular/core';

@Component({
  selector: 'app-card-list',
  templateUrl: './card-list.component.html',
  styleUrl: './card-list.component.css',
})
export class CardListComponent {
  status: boolean = true;

  constructor(private eRef: ElementRef) { }

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

  editEvent() {
    this.editStatus = false;
  }
  editTableName() {
    this.status = !this.status;
    this.editStatus = false;
  }


}
