import { CommonModule } from '@angular/common';
import { Component, Input, input } from '@angular/core';
import { LeadDTO } from '../../DTOs/lead';
import { LeadsServiceService } from './service/leads-service.service';

@Component({
  selector: 'app-leads',
  imports: [CommonModule],
  templateUrl: './leads.component.html',
  styleUrl: './leads.component.scss',
})
export class LeadsComponent {
  @Input() leads: LeadDTO[] = [];

  constructor(private service: LeadsServiceService) {}

  AcceptLead(lead: LeadDTO, status: number) {
    lead.status = status
    this.service.AcceptLead(lead).subscribe({
      next: (result) => {},
      error: (error) => {
        alert('ERRO');
      },
    });
  }

  DeclineLead(lead: LeadDTO, status: number) {
    lead.status = status
    this.service.DeclineLead(lead).subscribe({
      next: (result) => {},
      error: (error) => {
        alert('ERRO');
      },
    });
  }
}
