using System;

namespace ModuleHW
{
    public class CarsProvider : ICarsProvider
    {
        private readonly Random _random;

        public CarsProvider()
        {
            _random = new Random();
            Init();
        }

        public Car[] AllCars { get; private set; }

        private void Init()
        {
            AllCars = new Car[]
            {
                new JaguarIPaceEM(),
                new PorscheTaycanEM(),
                new NissanLeafEM(),
                new HyundaiIonicEM(),
                new TeslaModelSEM(),
                new ToyotaRAV4Hybrid(),
                new JaguarEPace(),
                new JaguarFPace(),
                new JaguarFType(),
                new JaguarXE(),
                new JaguarXF(),
                new CheryAmulet(),
                new CheryTiggo(),
                new GeelyEmgrand(),
                new GeelyMK(),
                new SkodaOctavia(),
                new SkodaSuperb(),
                new CitroenC4(),
                new Peugeot308(),
                new RenaultLogan(),
                new AudiA5(),
                new BMW520d(),
                new FiatDoblo(),
                new MitsubishiLancer(),
                new ToyotaPrius(),
                new HyundaiAccent(),
                new KiaOptima(),
                new ChevroletAveo(),
                new FordFocus(),
            };

            foreach (var car in AllCars)
            {
                if (car is ICECar)
                {
                    var iceCar = car as ICECar;

                    iceCar.AutomaticTransmission = _random.NextBool(60);
                }

                if (car is HybridCar)
                {
                    var hybridCar = car as HybridCar;
                    hybridCar.AutomaticTransmission = true;
                }

                if (car is EMCar)
                {
                    var emCar = car as EMCar;
                    emCar.AutomaticTransmission = true;
                }

                car.AirConditioning = _random.NextBool(60);
                car.Color = (CarColors)_random.Next(11);
                car.CurrencyUnit = CurrencyUnits.UAH;
                car.Mileage = _random.NextDoubleValue(1000, 10000);
                car.SpeedUnit = SpeedUnits.KMPH;
                car.WeightUnit = WeightUnits.KG;
                car.Year = _random.Next(2015, 2021);
            }
        }
    }
}
