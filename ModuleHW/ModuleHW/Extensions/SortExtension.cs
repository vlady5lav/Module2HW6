using System;
using System.Collections;

namespace ModuleHW
{
    public static class SortExtension
    {
        private static readonly BatteryConsumptionComparer _batteryConsumptionComparer;
        private static readonly FuelConsumptionComparer _fuelConsumptionComparer;
        private static readonly MaxSpeedComparer _maxSpeedComparer;
        private static readonly NameComparer _nameComparer;
        private static readonly PriceComparer _priceComparer;
        private static readonly WeightComparer _weightComparer;

        static SortExtension()
        {
            _batteryConsumptionComparer = new BatteryConsumptionComparer();
            _fuelConsumptionComparer = new FuelConsumptionComparer();
            _maxSpeedComparer = new MaxSpeedComparer();
            _nameComparer = new NameComparer();
            _priceComparer = new PriceComparer();
            _weightComparer = new WeightComparer();
        }

        public static Car[] SortByBatteryConsumption(this Car[] cars)
        {
            CarsCheck(cars);
            Array.Sort(cars, _batteryConsumptionComparer);
            return cars;
        }

        public static Car[] SortByFuelConsumption(this Car[] cars)
        {
            CarsCheck(cars);
            Array.Sort(cars, _fuelConsumptionComparer);
            return cars;
        }

        public static Car[] SortByMaxSpeed(this Car[] cars)
        {
            CarsCheck(cars);
            Array.Sort(cars, _maxSpeedComparer);
            return cars;
        }

        public static Car[] SortByName(this Car[] cars)
        {
            CarsCheck(cars);
            Array.Sort(cars, _nameComparer);
            return cars;
        }

        public static Car[] SortByPrice(this Car[] cars)
        {
            CarsCheck(cars);
            Array.Sort(cars, _priceComparer);
            return cars;
        }

        public static Car[] SortByWeight(this Car[] cars)
        {
            CarsCheck(cars);
            Array.Sort(cars, _weightComparer);
            return cars;
        }

        public static Car[] SortByChoose(this Car[] cars, IComparer comparer)
        {
            CarsCheck(cars);
            Array.Sort(cars, comparer);
            return cars;
        }

        public static void CarsCheck(Car[] cars)
        {
            if (cars.Length == 0)
            {
                Console.WriteLine("There is nothing to sort in SortExtension!");
                return;
            }
        }
    }
}
