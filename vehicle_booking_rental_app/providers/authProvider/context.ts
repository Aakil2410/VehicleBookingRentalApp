import { createContext } from "react";

export interface IUser { // all info needed by Dto
    Name: string,
    Surname: string,
    Gender: number,
    DOB: Date,//????
    IDNumber: string,
    ContactNumber: string,
    Addres: string,
    Email: string,
    Password: string,
    EmployeesNumber: string,
    Department: string
}

export interface ILogin {
    userNameOrEmailAddress: string;
    password: string;
  }

export interface IUserStateContext {
    readonly CreateUser?: IUser;
    readonly UserLogin?: ILogin;
    readonly userLogOut?: IUser;
}

export const INITIAL_STATE: IUserStateContext = {};

export interface IUserActionContext {   // Where all CRUD  functions go
    createUser?: (payload: IUser) => void;
    loginUser?: (payload: ILogin) => void;
    logoutUser?: () => void;
    //deleteUser?: (payload: id) => void;
}

// stores state > what is being manipulated > stores entity
const UserContext = createContext<IUserStateContext>(INITIAL_STATE);

// stores CRUD operations
const UserActionContext = createContext<IUserActionContext>({});

export { UserContext, UserActionContext};