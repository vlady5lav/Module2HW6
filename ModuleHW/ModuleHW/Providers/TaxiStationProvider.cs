using System;

namespace ModuleHW
{
    public class TaxiStationProvider : ITaxiStationProvider
    {
        private readonly ICarsService _carsService;
        private readonly Random _random;
        private readonly int? _taxiStationSize;

        public TaxiStationProvider(ICarsService carsService, IConfigService configService)
        {
            _carsService = carsService;
            _random = RandomHelper.Random;
            _taxiStationSize = configService.TaxiStationSize.Value;
            Init();
        }

        public Car[] TaxiStationCars { get; private set; }

        private void Init()
        {
            if (_carsService.AllCars == null)
            {
                Console.WriteLine("There is no cars in CarsService!");
                return;
            }

            TaxiStationCars = new Car[_taxiStationSize.Value];

            for (var i = 0; i < _taxiStationSize;)
            {
                var randomIndex = _random.Next(0, _carsService.AllCars.Length);
                var pickedCar = _carsService.AllCars[randomIndex];
                var duplicate = false;

                foreach (var car in TaxiStationCars)
                {
                    if (car == pickedCar)
                    {
                        duplicate = true;
                    }
                }

                if (!duplicate)
                {
                    TaxiStationCars[i] = pickedCar;
                    i++;
                }
            }
        }
    }
}
