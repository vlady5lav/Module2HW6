namespace ModuleHW
{
    public class ConfigProvider : IConfigProvider
    {
        private readonly Config _config;

        public ConfigProvider()
        {
            _config = Init();
        }

        public Config Config => _config;

        private Config Init()
        {
            return new Config()
            {
                FuelConsumptionConfig = new FuelConsumptionConfig()
                {
                    FuelConsumptionData = new FuelConsumptionData[]
                    {
                        new FuelConsumptionData
                        {
                            FuelConsumptionUnit = FuelConsumptionUnits.LP100KM,
                            Rate = 1.0,
                        },
                        new FuelConsumptionData
                        {
                            FuelConsumptionUnit = FuelConsumptionUnits.MPG,
                            Rate = 235.2,
                        }
                    },

                    CurrentFuelConsumptionUnit = FuelConsumptionUnits.LP100KM,
                },

                CurrencyConfig = new CurrencyConfig()
                {
                    CurrencyData = new CurrencyData[]
                    {
                        new CurrencyData
                        {
                            CurrencyUnit = CurrencyUnits.UAH,
                            DefaultToCurrentRate = 1.0,
                        },
                        new CurrencyData
                        {
                            CurrencyUnit = CurrencyUnits.USD,
                            DefaultToCurrentRate = 27.0,
                        },
                        new CurrencyData
                        {
                            CurrencyUnit = CurrencyUnits.EUR,
                            DefaultToCurrentRate = 31.0,
                        },
                    },

                    CurrentCurrencyUnit = CurrencyUnits.UAH,
                },

                SpeedConfig = new SpeedConfig()
                {
                    SpeedData = new SpeedData[]
                    {
                        new SpeedData
                        {
                            SpeedUnit = SpeedUnits.KMPH,
                            DefaultToCurrentRate = 1.0,
                        },
                        new SpeedData
                        {
                            SpeedUnit = SpeedUnits.MPH,
                            DefaultToCurrentRate = 1.61,
                        },
                    },

                    CurrentSpeedUnit = SpeedUnits.KMPH,
                },

                TaxiStationConfig = new TaxiStationConfig()
                {
                    TaxiStationSize = 50,
                },

                VolumeConfig = new VolumeConfig()
                {
                    VolumeData = new VolumeData[]
                    {
                        new VolumeData
                        {
                            VolumeUnit = VolumeUnits.L,
                            DefaultToCurrentRate = 1.0,
                        },
                        new VolumeData
                        {
                            VolumeUnit = VolumeUnits.GAL,
                            DefaultToCurrentRate = 3.7854,
                        },
                    },

                    CurrentVolumeUnit = VolumeUnits.L,
                },

                WeightConfig = new WeightConfig()
                {
                    WeightData = new WeightData[]
                    {
                        new WeightData
                        {
                            WeightUnit = WeightUnits.KG,
                            DefaultToCurrentRate = 1.0,
                        },
                        new WeightData
                        {
                            WeightUnit = WeightUnits.LB,
                            DefaultToCurrentRate = 0.4536,
                        },
                    },

                    CurrentWeightUnit = WeightUnits.KG,
                },
            };
        }
    }
}
