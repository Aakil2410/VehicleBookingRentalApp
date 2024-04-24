
import { HeroSection, Search, CustomFilter, VehicleCard} from "../../components";
import { getVehicles } from "../../providers/VehicleProvider";

export default async function Home() {

  const allVehicles = await getVehicles();

  const isDataEmpty = !Array.isArray(allVehicles) || allVehicles.length < 1 || !allVehicles;
  
  return (
    <main className='overflow-hidden'>
      <HeroSection />

      <div className='mt-12 padding-x padding-y max-width' id='discover'>
        <div className='home__text-container'>
          <h1 className='text-4xl font-extrabold'>Car Catalogue</h1>
          <p>Explore out cars you might like</p>
        </div>

        <div className='home__filters'>
          <Search />

          <div className='home__filter-container'>
            <CustomFilter title='fuel' />
            <CustomFilter title='year' />
          </div>
        </div>

         {!isDataEmpty ? (
          <section>
            <div className='home__cars-wrapper'>
              {allVehicles?.map((vehicle) => (
                <VehicleCard vehicle={vehicle} />
              ))}
            </div>

            {/* <ShowMore
              pageNumber={(searchParams.limit || 10) / 10}
              isNext={(searchParams.limit || 10) > allVehicles.length}
            /> */}
          </section>
        ) : (
          <div className='home__error-container'>
            <h2 className='text-black text-xl font-bold'>Oops, no results</h2>
            <p>{allVehicles?.message}</p>
          </div>
        )} 
      </div>
    </main>
  );
}
