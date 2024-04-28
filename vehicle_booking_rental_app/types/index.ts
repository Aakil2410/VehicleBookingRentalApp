import { MouseEventHandler } from "react";

export interface CustomButtonProps {
    title: string;
    containerStyles?: string;
    handleClick?: MouseEventHandler<HTMLButtonElement>;
    btnType?: "button" | "submit";
    textStyles?: string;
    rightIcon?: string;
    isDisabled?: boolean;
}

export interface SearchProps {
    setManufacturer: (manufacturer: string) => void;
    setModel: (model: string) => void;
  }

export interface FilterProps {
    manufacturer?: string;
    year?: number;
    model?: string;
    limit?: number;
    fuel?: string;
}

export interface OptionProps {
    title: string;
    value: string;
}

export interface CustomFilterProps<T> {
    options: OptionProps[];
    setFilter: (selected: T) => void;
  }

export interface SearchManufacturerProps {
    selected: string;
    setSelected: (selected: string) => void;
}

export interface VehicleProps {
    city_mpg: number;
    class: string;
    combination_mpg: number;
    cylinders: number;
    displacement: number;
    drive: string;
    fuel_type: string;
    highway_mpg: number;
    make: string;
    model: string;
    transmission: string;
    year: number;
}

export interface VehicleCardProps {
    model: string;
    make: string;
    mpg: number;
    transmission: string;
    year: number;
    drive: string;
    cityMPG: number;
  }

export type CarState = VehicleProps[] & { message?: string };

export interface ShowMoreVehiclesProps {
    pageNumber: number;
    isNext: boolean;
    setLimit: (limit: number) => void;
  }