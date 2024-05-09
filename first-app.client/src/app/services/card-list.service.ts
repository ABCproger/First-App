import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ApiResponse, ICardList } from '../shared/models/CardList';

@Injectable({
  providedIn: 'root'
})
export class CardListService {
  apiUrl = "https://localhost:5001/api/CardColumns"
  constructor(private http: HttpClient) { }
  getAllCardLists(): Observable<ApiResponse<ICardList[]>>{
    return this.http.get<ApiResponse<ICardList[]>>(`${this.apiUrl}`)
  }
  getCardList(id: number): Observable<ApiResponse<ICardList[]>>{
    return this.http.get<ApiResponse<ICardList[]>>(`${this.apiUrl}/${id}`)
  }
  createCardList(cardList: ICardList): Observable<ApiResponse<ICardList>>{
    return this.http.post<ApiResponse<ICardList>>(`${this.apiUrl}`, cardList);
  }
  updateCardList(id: number, cardList: ICardList){
    return this.http.patch<ApiResponse<ICardList>>(`${this.apiUrl}/${id}`,cardList);
  }
  deleteCardList(id: number): Observable<any>{
    return this.http.delete(`${this.apiUrl}/${id}`)
  }
}
