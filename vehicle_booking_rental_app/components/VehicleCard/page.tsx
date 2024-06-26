"use client";

import { useState } from "react";
import Image from "next/image";

import { VehicleProps } from "../../types";
import CustomButton from "../CustomButton/page";
import { calculateCarRent, generateVehicleImageUrl } from "../../providers/VehicleProvider";
import VehicleDetails from "../VehicleDetails/page";

interface VehicleCardProps {
  vehicle: VehicleProps;
}

const VehicleCard = ({ vehicle }: VehicleCardProps) => {
  
  const [isOpen, setIsOpen] = useState(false);

  const { city_mpg, make, model, drive, transmission, year } = vehicle;
  const VehicleRent = calculateCarRent(city_mpg, year);

  return (
    <div className="car-card group">
      <div className="car-card__content">
        <h2 className="car-card__content-title">
          {make} {model}
        </h2>
      </div>
      <p className="flex mt-6 text-[32px] font-extrabold">
        <span className="self-start text-[14px] font-semibold"></span>
        {VehicleRent}
        <span className="self-end text-[14px] font-medium">/day</span>
      </p>

      <div className="relative w-full h-40 my-3 object-contain">
        <Image
          src={generateVehicleImageUrl(vehicle,"")}
          //src={`https://cdn.imagin.studio/getimage?customer=${imaginApiKey}&make=${make}&modelFamily=${model.split(" ")[0]}&zoomType=fullscreen&modelYear=${year}`}
          alt="vehicle model"
          fill
          priority
          className="object-contain"
        />
      </div>

      <div className="relative flex w-full mt-2">
        <div className="flex group-hover:invisible w-full justify-between text-grey">
          <div className="flex flex-col justify-center items-center gap-2">
            <Image
              src="/steering-wheel.svg"
              width={20}
              height={20}
              alt="steering wheel"
            />
            <p className="text-[14px] leading-[17px]">
              {transmission === "a" ? "Automatic" : "Manual"}
            </p>
          </div>
          <div className="car-card__icon">
            <Image src="/tire.svg" width={20} height={20} alt="seat" />
            <p className="car-card__icon-text">{drive.toUpperCase()}</p>
          </div>
          <div className="car-card__icon">
            <Image src="/gas.svg" width={20} height={20} alt="seat" />
            <p className="car-card__icon-text">{city_mpg} MPG</p>
          </div>
        </div>

        <div className="car-card__btn-container">
          <CustomButton
            title="View More"
            containerStyles="w-full py-[16px] rounded-full bg-primary-blue"
            textStyles="text-white text-[14px] leading-[17px] font-bold"
            rightIcon="/right-arrow.svg"
            handleClick={() => setIsOpen(true)}
          />
        </div>

      {/* Book btn */}
        <div className="car-card__booking_btn-container">
          <CustomButton
            title="Book Now"
            containerStyles="w-full py-[16px] rounded-full bg-secondary-orange"
            textStyles="text-white text-[14px] leading-[17px] font-bold"
            rightIcon="/right-arrow.svg"
            handleClick={() => {}}
          />
        </div>
      </div>

      <VehicleDetails isOpen={isOpen} closeModal={() => setIsOpen(false)} vehicle={vehicle}/>
      {/* <Booking ... vehicle{vehicle}/> */}
    </div>
  );
};

export default VehicleCard;
