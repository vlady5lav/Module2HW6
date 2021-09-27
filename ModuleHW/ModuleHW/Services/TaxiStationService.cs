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
        public Car[] FilteredTaxiStationCars { get; private set; }
        public Car[] SortedTaxiStationCars { get; private set; }
        public Car[] SortedByNameTaxiStationCars { get; private set; }
        public Car[] SortedByFuelConsumptionTaxiStationCars { get; private set; }
        public Car[] TotalUniquesArray { get; private set; }
        public int TotalUniquesCount { get; private set; }

        public void GetFilteredTaxiStationCars(string name)
        {
            FilteredTaxiStationCars = new Car[TotalUniquesArray.Search(name).Length];
            FilteredTaxiStationCars = TotalUniquesArray.Search(name);
        }

        public void GetFilteredTaxiStationCars(CarBodyTypes carType)
        {
            FilteredTaxiStationCars = new Car[TotalUniquesArray.Search(carType).Length];
            FilteredTaxiStationCars = TotalUniquesArray.Search(carType);
        }

        public void GetSortedCarTaxiStation(string sort)
        {
            switch (sort)
            {
                case "FuelConsumption":
                    SortedByFuelConsumptionTaxiStationCars = (Car[])TotalUniquesArray.Search(CarEngineTypes.Hybrid, CarEngineTypes.ICE).Clone();
                    SortedByFuelConsumptionTaxiStationCars.SortByFuelConsumption();
                    return;
                case "MaxSpeed":
                    SortedTaxiStationCars = (Car[])TotalUniquesArray.Clone();
                    SortedTaxiStationCars.SortByMaxSpeed();
                    return;
                case "Name":
                    SortedByNameTaxiStationCars = (Car[])TotalUniquesArray.Clone();
                    SortedByNameTaxiStationCars.SortByName();
                    return;
                case "Price":
                    SortedTaxiStationCars = (Car[])TotalUniquesArray.Clone();
                    SortedTaxiStationCars.SortByPrice();
                    return;
                case "Weight":
                    SortedTaxiStationCars = (Car[])TotalUniquesArray.Clone();
                    SortedTaxiStationCars.SortByWeight();
                    return;
                default:
                    throw new Exception("Error in sort switch!");
            }
        }

        private void Init()
        {
            if (_taxiStationProvider.TaxiStationCars == null || _taxiStationProvider.TaxiStationCars.Length == 0)
            {
                Console.WriteLine("There is no cars in TaxiStationProvider!");
                return;
            }

            TaxiStationCars = new Car[_taxiStationProvider.TaxiStationCars.Length];
            _taxiStationProvider.TaxiStationCars.CopyTo(TaxiStationCars, 0);
            TotalUniquesArray = TaxiStationCars.GetTotalUniquesArray();
            TotalUniquesCount = TaxiStationCars.GetTotalUniquesCount();
            GetFilteredTaxiStationCars(CarBodyTypes.Sedan);
            GetSortedCarTaxiStation("Name");
            GetSortedCarTaxiStation("FuelConsumption");
        }
    }
}
