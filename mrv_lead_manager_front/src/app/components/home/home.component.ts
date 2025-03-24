import { Component } from '@angular/core';
import { LeadsComponent } from '../leads/leads.component';
import { HomeService } from './service/home.service';
import { LeadDTO } from '../../DTOs/lead';

@Component({
  selector: 'app-home',
  imports: [LeadsComponent],
  templateUrl: './home.component.html',
  styleUrl: './home.component.scss',
})
export class HomeComponent {
  constructor(private service: HomeService) {}

  leads: LeadDTO[] = [];

  leadsInvited() {
    this.service.getInvited().subscribe({
      next: (result) => {
        this.leads = result;
      },
      error: (error) => {
        alert('ERRO');
      },
    });
  }

  leadsAccepted() {
    this.service.getInvited().subscribe({
      next: (result) => {
        this.leads = result;
      },
      error: (error) => {
        alert('ERRO');
      },
    });
  }
}
