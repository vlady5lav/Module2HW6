namespace ModuleHW
{
    public interface ITaxiStationService
    {
        Car[] FilteredCars { get; }
        Car[] SortedByFuelConsumption { get; }
        Car[] SortedByName { get; }
        Car[] SortedCars { get; }
        Car[] TaxiStationCars { get; }
        Car[] TotalUniquesArray { get; }
        int TotalUniquesCount { get; }

        void CarsCheck(Car[] cars);
        Car[] GetFilteredCars(Car[] cars, CarBodyTypes carType);
        Car[] GetFilteredCars(Car[] cars, string name);
        Car[] GetSortedCars(Car[] cars, string sort);
    }
}