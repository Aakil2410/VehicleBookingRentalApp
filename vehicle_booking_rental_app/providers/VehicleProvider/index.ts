import { FilterProps, VehicleProps } from "../../types";

export async function getVehicles(filters: FilterProps) {
    const { manufacturer, year, model, limit, fuel } = filters;
    const headers = {
        'X-RapidAPI-Key': '5675e55159msh7b1d5e20c76f047p14c1e2jsn9370f66c0e94',
        'X-RapidAPI-Host': 'cars-by-api-ninjas.p.rapidapi.com'
    }

    console.log(manufacturer+'<*************************************');
    if (manufacturer !==""){
        const response = await fetch(`https://cars-by-api-ninjas.p.rapidapi.com/v1/cars?make=${manufacturer}&year=${year}&model=${model}&limit=${limit}&fuel_type=${fuel}`, { headers: headers, });
        console.log(response);
        const result = await response.json();

    return result;
    } else{}
    const response = await fetch(`https://cars-by-api-ninjas.p.rapidapi.com/v1/cars?make=${manufacturer}&year=${year}&model=${model}&limit=${limit}&fuel_type=${fuel}`, { headers: headers, });
    console.log(response);
    const result = await response.json();

    return result;
}

export const generateVehicleImageUrl = (vehicle: VehicleProps, angle?: string) => {
    const url = new URL("https://cdn.imagin.studio/getimage");
    const { make, model, year } = vehicle;

    url.searchParams.append('customer', 'hrjavascript-mastery' || '');
    url.searchParams.append('make', make);
    url.searchParams.append('modelFamily', model.split(" ")[0]);
    url.searchParams.append('zoomType', 'fullscreen');
    url.searchParams.append('modelYear', `${year}`);
    //url.searchParams.append('zoomLevel', zoomLevel);
    url.searchParams.append('angle', `${angle}`);
    return `${url}`;
}

export const calculateCarRent = (city_mpg: number, year: number) => {
    const basePricePerDay = 50; // Base rental price per day in dollars
    const mileageFactor = 0.1; // Additional rate per mile driven
    const ageFactor = 0.05; // Additional rate per year of vehicle age

    // Calculate additional rate based on mileage and age
    const mileageRate = city_mpg * mileageFactor;
    const ageRate = (new Date().getFullYear() - year) * ageFactor;

    // Calculate total rental rate per day
    const rentalRatePerDay = basePricePerDay + mileageRate + ageRate;

    return rentalRatePerDay.toFixed(0);
};

export const updateSearchParams = (type: string, value: string) => {
    // Get the current URL search params
    const searchParams = new URLSearchParams(window.location.search);

    // Set the specified search parameter to the given value
    searchParams.set(type, value);

    // Set the specified search parameter to the given value
    const newPathname = `${window.location.pathname}?${searchParams.toString()}`;

    return newPathname;
};

export const deleteSearchParams = (type: string) => {
    // Set the specified search parameter to the given value
    const newSearchParams = new URLSearchParams(window.location.search);

    // Delete the specified search parameter
    newSearchParams.delete(type.toLocaleLowerCase());

    // Construct the updated URL pathname with the deleted search parameter
    const newPathname = `${window.location.pathname}?${newSearchParams.toString()}`;

    return newPathname;
};