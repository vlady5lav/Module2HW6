namespace ModuleHW
{
    public interface ITaxiStationService
    {
        Car[] FilteredTaxiStationCars { get; }
        Car[] SortedTaxiStationCars { get; }
        Car[] TaxiStationCars { get; }
        Car[] TotalUniquesArray { get; }
        int TotalUniquesCount { get; }

        void GetFilteredTaxiStationCars(CarBodyTypes carType);
        void GetFilteredTaxiStationCars(string name);
        void GetSortedCarTaxiStation(string sort);
    }
}