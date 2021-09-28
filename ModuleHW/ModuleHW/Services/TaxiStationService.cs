using System;

namespace ModuleHW
{
    public class TaxiStationService : ITaxiStationService
    {
        private readonly ITaxiStationProvider _taxiStationProvider;

        public TaxiStationService(ITaxiStationProvider taxiStationProvider)
        {
            _taxiStationProvider = taxiStationProvider;
            Init();
        }

        public Car[] TaxiStationCars { get; private set; }
        public Car[] FilteredCars { get; private set; }
        public Car[] SortedCars { get; private set; }
        public Car[] SortedByName { get; private set; }
        public Car[] SortedByFuelConsumption { get; private set; }
        public Car[] TotalUniquesArray { get; private set; }
        public int TotalUniquesCount { get; private set; }

        public void CarsCheck(Car[] cars)
        {
            if (cars == null)
            {
                Console.WriteLine("There is nothing to do in TaxiStationService!");
                return;
            }
        }

        public Car[] GetFilteredCars(Car[] cars, string name)
        {
            CarsCheck(cars);
            return cars.SearchByName(name);
        }

        public Car[] GetFilteredCars(Car[] cars, CarBodyTypes bodyType)
        {
            CarsCheck(cars);
            return cars.SearchByBodyType(bodyType);
        }

        public Car[] GetSortedCars(Car[] cars, string sort)
        {
            CarsCheck(cars);

            switch (sort)
            {
                case "BatteryConsumption":
                    return cars.SearchByEngineType(CarEngineTypes.EM).SortByBatteryConsumption();
                case "FuelConsumption":
                    return cars.SearchByEngineType(CarEngineTypes.Hybrid, CarEngineTypes.ICE).SortByFuelConsumption();
                case "MaxSpeed":
                    return cars.SortByMaxSpeed();
                case "Name":
                    return cars.SortByName();
                case "Price":
                    return cars.SortByPrice();
                case "Weight":
                    return cars.SortByWeight();
                default:
                    throw new Exception("Error in sort switch!");
            }
        }

        private void Init()
        {
            CarsCheck(_taxiStationProvider.TaxiStationCars);

            TaxiStationCars = (Car[])_taxiStationProvider.TaxiStationCars.SortByName().Clone();
            TotalUniquesArray = TaxiStationCars.GetTotalUniquesArray();
            TotalUniquesCount = TotalUniquesArray.Length;
            FilteredCars = (Car[])GetFilteredCars(TotalUniquesArray, CarBodyTypes.Sedan).Clone();
            SortedByName = (Car[])GetSortedCars(TotalUniquesArray, "Name").Clone();
            SortedByFuelConsumption = (Car[])GetSortedCars(TotalUniquesArray, "FuelConsumption").Clone();
            SortedCars = (Car[])GetSortedCars(TotalUniquesArray, "BatteryConsumption").Clone();
        }
    }
}
