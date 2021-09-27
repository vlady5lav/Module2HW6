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

            Console.WriteLine($"{Environment.NewLine}All cars in Taxi Station (Total price: {_taxiStationService.TaxiStationCars.GetTotalPrice()} UAH):{Environment.NewLine}");

            DisplayOutput(_taxiStationService.TaxiStationCars);

            Console.WriteLine($"{Environment.NewLine}Filtered cars by type \"Sedan\":{Environment.NewLine}");

            DisplayOutput(_taxiStationService.FilteredTaxiStationCars);

            Console.WriteLine($"{Environment.NewLine}Sorted cars by Name:{Environment.NewLine}");

            DisplayOutput(_taxiStationService.SortedTaxiStationCars);

            Console.WriteLine($"{Environment.NewLine}Unique cars (Total: {_taxiStationService.TotalUniquesCount} unique cars):{Environment.NewLine}");

            DisplayOutput(_taxiStationService.TotalUniquesArray);

            Console.WriteLine(string.Empty);
            Console.ReadKey();
        }

        public void DisplayOutput(Car[] cars)
        {
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Manufacturer} {car.Model}");
            }

            Console.WriteLine($"{Environment.NewLine}=================================================================");
        }
    }
}
