import { Component } from '@angular/core';

@Component({
  selector: 'app-new-list',
  templateUrl: './new-list.component.html',
  styleUrl: './new-list.component.css'
})
export class NewListComponent {
  status: boolean = true;
  clickEvent() {
    this.status = !this.status;
  }
}
