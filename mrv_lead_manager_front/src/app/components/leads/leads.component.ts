import { CommonModule } from '@angular/common';
import { Component, Input, input } from '@angular/core';
import { LeadDTO } from '../../DTOs/lead';

@Component({
  selector: 'app-leads',
  imports: [CommonModule],
  templateUrl: './leads.component.html',
  styleUrl: './leads.component.scss',
})
export class LeadsComponent {
  @Input() leads: LeadDTO[] = [];

  constructor() {}
}
