"use client";

import { ShowMoreVehiclesProps } from "../../types";
import { CustomButton } from "../../components";

const ShowMoreVehicles = ({ pageNumber, isNext, setLimit }: ShowMoreVehiclesProps) => {

  
    const handleNavigation = () => {
      const newLimit = (pageNumber + 1) * 10;
  
      setLimit(newLimit);
    };
  
    return (
      <div className="w-full flex-center gap-5 mt-10">
        {!isNext && (
          <CustomButton
            btnType="button"
            title="Show More"
            containerStyles="bg-primary-blue rounded-full text-white"
            handleClick={handleNavigation}
          />
        )}
      </div>
    );
  };

export default ShowMoreVehicles
