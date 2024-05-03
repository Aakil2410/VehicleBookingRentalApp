"use client";

import { useEffect, useState } from "react";
import Image from "next/image";
import {
  HeroSection,
  Search,
  CustomFilter,
  VehicleCard,
  ShowMoreVehicles,
} from "../../components";
import { fetchVehicles } from "../../providers/VehicleProvider";
import { fuels, yearsOfProduction } from "../../constants";

export default function Home() {
  const [allVehicles, setAllVehicles] = useState([]);
  const [loading, setLoading] = useState(false);

  const [manufacturer, setManufacturer] = useState("");
  const [model, setModel] = useState("");

  const [fuel, setFuel] = useState("");
  const [year, setYear] = useState(2022);

  const [limit, setLimit] = useState(10);

  const getVehicles = async () => {
    setLoading(true);
    try {
      const result = await fetchVehicles({
        manufacturer: manufacturer.toLowerCase() || "",
        model: model.toLowerCase() || "",
        fuel: fuel.toLowerCase() || "",
        year: year || 2022,
        limit: limit || 10,
      });
      setAllVehicles(result);
    } catch (error) {
      console.log(error);
    } finally {
      setLoading(false);
    }
  };

  useEffect(() => {
    getVehicles();
  }, [fuel, year, limit, manufacturer, model]);

  return (
    <>
    
    <main className="overflow-hidden">
      <HeroSection />

      <div className="mt-12 padding-x padding-y max-width" id="discover">
        <div className="home__text-container">
          <h1 className="text-4xl font-extrabold">Car Catalogue</h1>
          <p>Explore out cars you might like</p>
        </div>

        <div className="home__filters">
          <Search setManufacturer={setManufacturer} setModel={setModel} />

          <div className="home__filter-container">
            <CustomFilter options={fuels} setFilter={setFuel} />
            <CustomFilter options={yearsOfProduction} setFilter={setYear}
            />
          </div>
        </div>

        {allVehicles === null ? (
          <h1>Search for a vehicle</h1>
        ) : (allVehicles.length > 0 || allVehicles!== null ? (
          <section>
            <div className="home__cars-wrapper">
              {allVehicles?.map((vehicle, index) => (
                <VehicleCard key={`vehicle-${index}`} vehicle={vehicle} />
              ))}
            </div>

            {loading && (
              <div className="mt-16 w-full flex-center">
                <Image
                  src="/loaader.svg"
                  alt="loading"
                  width={50}
                  height={50}
                  className="object-contain"
                />
              </div>
            )}

            <ShowMoreVehicles
              pageNumber={limit / 10}
              isNext={limit > allVehicles.length}
              setLimit={setLimit}
            />
          </section>
        ) : (
          !loading && (
            <div className="home__error-container">
              <h2 className="text-black text-xl font-bold">Oops, no results</h2>
              <p>{allVehicles?.message}</p>
            </div>
          )
        ))}
      </div>
    </main>
    </>
  );
}
