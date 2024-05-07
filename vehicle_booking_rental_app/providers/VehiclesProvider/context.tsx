import { createContext } from "react";

export interface IVehicle{
    class: string,
    make: string,
    model: string,
    year: number,
    vin: string,
    licensePlateNumber:string,
    mileage:number,
    fuelType: string,
    color: string,
    baseRentalPrice:number,
    vehicleStatus: number
}

export interface IFilter {
    make?: string;
    model?: string;
    year?: number;
    fuelType?: string;
}

export interface IVehicleStateContext {
    readonly CreateVehicle?: IVehicle;
    readonly SearchVehicles?: IVehicle[];
    readonly GetVehicle?: IVehicle;
}

export const INITIAL_STATE: IVehicleStateContext = {};

export interface IUserActionContext {   // Where all CRUD  functions go
    createVehicle?: (payload: IVehicle) => void;
    getVehicle?: (payload: IVehicle) =>
}