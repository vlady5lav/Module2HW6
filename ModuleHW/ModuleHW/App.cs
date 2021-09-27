using System;

namespace ModuleHW
{
    public class App
    {
        private readonly ITaxiStationService _taxiStationService;

        public App(ITaxiStationService taxiStationService)
        {
            _taxiStationService = taxiStationService;
        }

        public void Start()
        {
            if (_taxiStationService.TaxiStationCars == null || _taxiStationService.TaxiStationCars.Length == 0)
            {
                Console.WriteLine("There is no cars in TaxiStationService!");
                return;
            }

            Console.WriteLine($"{Environment.NewLine}List of all available cars in Taxi Station (Total price: {_taxiStationService.TaxiStationCars.GetTotalPrice()} UAH):{Environment.NewLine}");
            DisplayOutput(_taxiStationService.TaxiStationCars);

            Console.WriteLine($"{Environment.NewLine}List of all car models filtered by type \"Sedan\":{Environment.NewLine}");
            DisplayOutput(_taxiStationService.FilteredCars);

            Console.WriteLine($"{Environment.NewLine}List of all car models sorted by \"Name\":{Environment.NewLine}");
            DisplayOutput(_taxiStationService.SortedByName);

            Console.WriteLine($"{Environment.NewLine}List of all car models sorted by \"Fuel Consumption\"{Environment.NewLine}");
            DisplayOutputFuelConsumption(_taxiStationService.SortedByFuelConsumption);

            Console.WriteLine($"{Environment.NewLine}List of all car models sorted by \"Battery Consumption\"{Environment.NewLine}");
            DisplayOutputFuelConsumption(_taxiStationService.SortedCars);

            Console.WriteLine($"{Environment.NewLine}List of all unique car models (Total: {_taxiStationService.TotalUniquesCount} models):{Environment.NewLine}");
            DisplayOutput(_taxiStationService.TotalUniquesArray);

            Console.WriteLine(string.Empty);
            Console.ReadKey();
        }

        public void DisplayOutput(Car[] cars)
        {
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Manufacturer} {car.Model} ({car.Year})");
            }

            Console.WriteLine($"{Environment.NewLine}=================================================================");
        }

        public void DisplayOutputFuelConsumption(Car[] cars)
        {
            foreach (var car in cars)
            {
                if (car.FuelConsumption != null)
                {
                    Console.WriteLine($"{car.Manufacturer} {car.Model} ({car.Year}) --  {car.FuelConsumption} litres/100km (Tank Capacity = {car.FuelTankCapacity} litres)");
                }

                if (car.BatteryConsumption != null)
                {
                    Console.WriteLine($"{car.Manufacturer} {car.Model} ({car.Year}) --  {car.BatteryConsumption} WHrs/100km (Battery Capacity = {car.BatteryCapacity} WHrs)");
                }
            }

            Console.WriteLine($"{Environment.NewLine}=================================================================");
        }
    }
}
