export interface ApiResponse<T>{
    message?:string;
    data: T
}
export interface ICardList{
    _id?: string;
    name: string;
    boardId: number;
}
export interface ICard{
    _id?: string;
    description: string;
    dueDate:  Date;
    cardColumnId: number;
}
