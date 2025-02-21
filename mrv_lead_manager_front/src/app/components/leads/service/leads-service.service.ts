import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { LeadDTO } from '../../../DTOs/lead';
import { Observable } from 'rxjs';
import { environment } from '../../../../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class LeadsServiceService {
  private BASEURL = `${environment.baseURL}` + 'Leads/';

  constructor(private httpcliente: HttpClient) {}

  updateLead(param: LeadDTO): Observable<LeadDTO> {
    return this.httpcliente.put<LeadDTO>(`${this.BASEURL}Getall`, param);
  }
}
