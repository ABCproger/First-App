export interface ApiResponse<T>{
    message?:string;
    data: T
}
export interface ICardActivity{
    _id?: string;
    name: string;
    boardId: number;
}