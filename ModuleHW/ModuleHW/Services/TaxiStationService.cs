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
        public Car[] TotalUniquesArray { get; private set; }
        public int TotalUniquesCount { get; private set; }

        public void GetFilteredTaxiStationCars(string name)
        {
            FilteredTaxiStationCars = new Car[TaxiStationCars.Search(name).Length];
            FilteredTaxiStationCars = TaxiStationCars.Search(name);
        }

        public void GetFilteredTaxiStationCars(CarBodyTypes carType)
        {
            FilteredTaxiStationCars = new Car[TaxiStationCars.Search(carType).Length];
            FilteredTaxiStationCars = TaxiStationCars.Search(carType);
        }

        public void GetSortedCarTaxiStation(string sort)
        {
            SortedTaxiStationCars = new Car[TaxiStationCars.Length];
            TaxiStationCars.CopyTo(SortedTaxiStationCars, 0);

            switch (sort)
            {
                case "Name":
                    SortedTaxiStationCars.SortByName();
                    return;
                case "Price":
                    SortedTaxiStationCars.SortByPrice();
                    return;
                case "Weight":
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
            GetFilteredTaxiStationCars(CarBodyTypes.Sedan);
            GetSortedCarTaxiStation("Name");
            TotalUniquesArray = TaxiStationCars.GetTotalUniquesArray();
            TotalUniquesCount = TaxiStationCars.GetTotalUniquesCount();
        }
    }
}
