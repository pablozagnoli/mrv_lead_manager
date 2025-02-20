import { Component } from '@angular/core';
import { LeadsComponent } from "../leads/leads.component";

@Component({
  selector: 'app-home',
  imports: [LeadsComponent],
  templateUrl: './home.component.html',
  styleUrl: './home.component.scss'
})
export class HomeComponent {

  leadsInvited(){
    alert("Invited")
  }
  leadsAccepted(){
    alert("Accepted")
  }
}
