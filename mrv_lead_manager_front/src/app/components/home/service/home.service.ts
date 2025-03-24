import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from '../../../../environments/environment';
import { LeadDTO } from '../../../DTOs/lead';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class HomeService {
  private BASEURL = `${environment.baseURL}` + 'Leads/';

  constructor(private httpcliente: HttpClient) {}

  getAllLeads(): Observable<LeadDTO[]> {
    return this.httpcliente.get<LeadDTO[]>(`${this.BASEURL}Getall`);
  }

  getInvited(): Observable<LeadDTO[]> {
    return this.httpcliente.get<LeadDTO[]>(`${this.BASEURL}Getall-invited`);
  }

  getAccepted(): Observable<LeadDTO[]> {
    return this.httpcliente.get<LeadDTO[]>(`${this.BASEURL}Getall-accepted`);
  }

  updateLead(param: LeadDTO): Observable<LeadDTO> {
    return this.httpcliente.put<LeadDTO>(`${this.BASEURL}Getall`, param);
  }
}
