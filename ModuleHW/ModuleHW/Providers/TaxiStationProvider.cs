using System;

namespace ModuleHW
{
    public class TaxiStationProvider : ITaxiStationProvider
    {
        private readonly ICarsService _carsService;
        private readonly Random _random;
        private readonly int _taxiStationSize;

        public TaxiStationProvider(ICarsService carsService, IConfigService configService)
        {
            _carsService = carsService;
            _random = new Random();
            _taxiStationSize = configService.TaxiStationSize;
            Init();
        }

        public Car[] TaxiStationCars { get; private set; }

        private void Init()
        {
            if (_carsService.AllCars.Length == 0)
            {
                Console.WriteLine("There is no cars in CarsService!");
                return;
            }

            TaxiStationCars = new Car[_taxiStationSize];

            for (var i = 0; i < _taxiStationSize; i++)
            {
                var randomIndex = _random.Next(0, _carsService.AllCars.Length);
                var pickedCar = _carsService.AllCars[randomIndex];
                TaxiStationCars[i] = pickedCar;
            }
        }
    }
}
