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
        private readonly MileageConfig _mileageConfig;
        private readonly MileageData[] _mileageData;
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
            _mileageConfig = _configService.MileageConfig;
            _mileageData = _configService.MileageData;
            _speedConfig = _configService.SpeedConfig;
            _speedData = _configService.SpeedData;
            _weightConfig = _configService.WeightConfig;
            _weightData = _configService.WeightData;

            Init();
        }

        public Car[] AllCars { get; private set; }

        public void CarsCheck(Car[] cars)
        {
            if (cars == null)
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
                if (car is ICECar || car is HybridCar)
                {
                    if (car.FuelConsumptionUnit == FuelConsumptionUnits.MPG)
                    {
                        var fuelConsumptionData = GetFuelConsumptionData(car.FuelConsumptionUnit.Value);
                        if (fuelConsumptionData.Rate != null)
                        {
                            car.FuelConsumption = fuelConsumptionData.Rate / car.FuelConsumption;
                            car.FuelConsumptionUnit = _fuelConsumptionConfig.CurrentFuelConsumptionUnit;
                        }
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
                var currencyData = GetCurrencyData(car.CurrencyUnit.Value);
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

        private void ConvertMileage(Car[] cars)
        {
            CarsCheck(cars);

            foreach (var car in cars)
            {
                var mileageData = GetMileageData(car.MileageUnit.Value);
                car.Mileage *= Math.Round((double)mileageData.DefaultToCurrentRate, 0);
                car.MileageUnit = _mileageConfig.CurrentMileageUnit;
            }
        }

        private MileageData GetMileageData(MileageUnits mileageUnit)
        {
            foreach (var mileageData in _mileageData)
            {
                if (mileageData.MileageUnit == mileageUnit)
                {
                    return mileageData;
                }
            }

            return null;
        }

        private void ConvertSpeed(Car[] cars)
        {
            CarsCheck(cars);

            foreach (var car in cars)
            {
                var speedData = GetSpeedData(car.SpeedUnit.Value);
                car.MaxSpeed *= (int)Math.Round((double)speedData.DefaultToCurrentRate, 0);
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
                var weightData = GetWeightData(car.WeightUnit.Value);
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
            ConvertMileage(AllCars);
            ConvertSpeed(AllCars);
            ConvertWeight(AllCars);
        }
    }
}
