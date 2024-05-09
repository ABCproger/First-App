import { Component, HostListener, ElementRef, ViewChild } from '@angular/core';

@Component({
  selector: 'app-card-component',
  templateUrl: './card-component.component.html',
  styleUrls: ['./card-component.component.css'],
})
export class CardComponentComponent {
  status: boolean = false;
  modalStatus: boolean = false;

  @ViewChild('moreButton', { static: false }) moreButton!: ElementRef;
  @ViewChild('modalWindow', { static: false }) modalWindow!: ElementRef;
  @ViewChild('cardBody', { static: false }) cardBody!: ElementRef;

  constructor(private eRef: ElementRef) {}

  clickEvent() {
    this.status = !this.status;
    console.log('clicked');
  }
  modalClickEvent() {
    this.modalStatus = !this.status;
    this.status = false;
    console.log('clicked');
  }

  @HostListener('document:click', ['$event'])
  clickOutOfModal(event: any) {
    if (event.target !== this.modalWindow.nativeElement) {
      console.log('clicked outside of modal');
      this.modalStatus = false;
      this.status = false;
    }
  }

  closeModal() {}
}
