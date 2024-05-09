export interface ApiResponse<T>{
    message?:string;
    data: T
}
export interface ICard{
    _id?: string;
    description: string;
    dueDate:  Date;
    cardColumnId: number;
}