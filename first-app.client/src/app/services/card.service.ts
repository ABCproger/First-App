import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ApiResponse, ICard } from '../shared/models/Card';

@Injectable({
  providedIn: 'root'
})
export class CardService {
  apiUrl = "https://localhost:5001/api/Card"
  constructor(private http: HttpClient) { }
  getAllCardLists(): Observable<ApiResponse<ICard[]>>{
    return this.http.get<ApiResponse<ICard[]>>(`${this.apiUrl}`)
  }
  getCardList(id: number): Observable<ApiResponse<ICard[]>>{
    return this.http.get<ApiResponse<ICard[]>>(`${this.apiUrl}/${id}`)
  }
  createCardList(card: ICard): Observable<ApiResponse<ICard>>{
    return this.http.post<ApiResponse<ICard>>(`${this.apiUrl}`, card);
  }
  updateCardList(id: number, card: ICard){
    return this.http.patch<ApiResponse<ICard>>(`${this.apiUrl}/${id}`,card);
  }
  deleteCardList(id: number): Observable<any>{
    return this.http.delete(`${this.apiUrl}/${id}`)
  }
}
