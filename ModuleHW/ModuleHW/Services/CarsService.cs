using System;

namespace ModuleHW
{
    public class CarsService : ICarsService
    {
        private readonly ICarsProvider _carsProvider;
        private readonly IConfigService _configService;
        private readonly CurrencyConfig _currencyConfig;
        private readonly CurrencyData[] _currencyData;
        private readonly FuelConsumptionConfig _fuelConsumptionConfig;
        private readonly FuelConsumptionData[] _fuelConsumptionData;
        private readonly SpeedConfig _speedConfig;
        private readonly SpeedData[] _speedData;
        private readonly WeightConfig _weightConfig;
        private readonly WeightData[] _weightData;

        public CarsService(ICarsProvider carsProvider, IConfigService configService)
        {
            _carsProvider = carsProvider;
            _configService = configService;
            _currencyConfig = _configService.CurrencyConfig;
            _currencyData = _configService.CurrencyData;
            _fuelConsumptionConfig = _configService.FuelConsumptionConfig;
            _fuelConsumptionData = _configService.FuelConsumptionData;
            _speedConfig = _configService.SpeedConfig;
            _speedData = _configService.SpeedData;
            _weightConfig = _configService.WeightConfig;
            _weightData = _configService.WeightData;

            Init();
        }

        public Car[] AllCars { get; private set; }

        public void CarsCheck(Car[] cars)
        {
            if (cars.Length == 0)
            {
                Console.WriteLine("There is nothing to do in CarsService!");
                return;
            }
        }

        private void ConvertFuelConsumption(Car[] cars)
        {
            CarsCheck(cars);

            foreach (var car in cars)
            {
                if (car is ICECar)
                {
                    var iceCar = car as ICECar;

                    if (iceCar.FuelConsumptionUnit == FuelConsumptionUnits.MPG)
                    {
                        var fuelConsumptionData = GetFuelConsumptionData(iceCar.FuelConsumptionUnit);
                        iceCar.FuelConsumption = fuelConsumptionData.Rate / iceCar.FuelConsumption;
                        iceCar.FuelConsumptionUnit = _fuelConsumptionConfig.CurrentFuelConsumptionUnit;
                    }
                }
                else if (car is HybridCar)
                {
                    var hybridCar = car as HybridCar;

                    if (hybridCar.FuelConsumptionUnit == FuelConsumptionUnits.MPG)
                    {
                        var fuelConsumptionData = GetFuelConsumptionData(hybridCar.FuelConsumptionUnit);
                        hybridCar.FuelConsumption = fuelConsumptionData.Rate / hybridCar.FuelConsumption;
                        hybridCar.FuelConsumptionUnit = _fuelConsumptionConfig.CurrentFuelConsumptionUnit;
                    }
                }
            }
        }

        private FuelConsumptionData GetFuelConsumptionData(FuelConsumptionUnits fuelConsumptionUnit)
        {
            foreach (var fuelConsumptionData in _fuelConsumptionData)
            {
                if (fuelConsumptionData.FuelConsumptionUnit == fuelConsumptionUnit)
                {
                    return fuelConsumptionData;
                }
            }

            return null;
        }

        private void ConvertCurrency(Car[] cars)
        {
            CarsCheck(cars);

            foreach (var car in cars)
            {
                var currencyData = GetCurrencyData(car.CurrencyUnit);
                car.Price *= currencyData.DefaultToCurrentRate;
                car.CurrencyUnit = _currencyConfig.CurrentCurrencyUnit;
            }
        }

        private CurrencyData GetCurrencyData(CurrencyUnits currencyUnit)
        {
            foreach (var currencyData in _currencyData)
            {
                if (currencyData.CurrencyUnit == currencyUnit)
                {
                    return currencyData;
                }
            }

            return null;
        }

        private void ConvertSpeed(Car[] cars)
        {
            CarsCheck(cars);

            foreach (var car in cars)
            {
                var speedData = GetSpeedData(car.SpeedUnit);
                car.MaxSpeed *= (int)Math.Round(speedData.DefaultToCurrentRate, 0);
                car.SpeedUnit = _speedConfig.CurrentSpeedUnit;
            }
        }

        private SpeedData GetSpeedData(SpeedUnits speedUnit)
        {
            foreach (var speedData in _speedData)
            {
                if (speedData.SpeedUnit == speedUnit)
                {
                    return speedData;
                }
            }

            return null;
        }

        private void ConvertWeight(Car[] cars)
        {
            CarsCheck(cars);

            foreach (var car in cars)
            {
                var weightData = GetWeightData(car.WeightUnit);
                car.Weight *= weightData.DefaultToCurrentRate;
                car.WeightUnit = _weightConfig.CurrentWeightUnit;
            }
        }

        private WeightData GetWeightData(WeightUnits weightUnit)
        {
            foreach (var weightData in _weightData)
            {
                if (weightData.WeightUnit == weightUnit)
                {
                    return weightData;
                }
            }

            return null;
        }

        private void Init()
        {
            AllCars = (Car[])_carsProvider.AllCars.Clone();
            CarsCheck(AllCars);
            ConvertFuelConsumption(AllCars);
            ConvertCurrency(AllCars);
            ConvertSpeed(AllCars);
            ConvertWeight(AllCars);
        }
    }
}
