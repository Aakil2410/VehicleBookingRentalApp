import { createContext } from "react";

export interface IUser { // all info needed by Dto
    name: string,
    surname: string,
    gender: number,
    dob: Date,//????
    idNumber: string,
    contactNumber: string,
    addres: string,
    email: string,
    credit: number,
    isAdditionalDriver: boolean,
    password: string,
    employeeNumber: string,
    department: number
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