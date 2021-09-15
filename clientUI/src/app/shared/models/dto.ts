import { IDepartment } from "./departments";

export interface IDto {
    data: IDepartment[];
    isSuccess: boolean;
    message: string;
}