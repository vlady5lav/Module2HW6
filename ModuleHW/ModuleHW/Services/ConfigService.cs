namespace ModuleHW
{
    public class ConfigService : IConfigService
    {
        private readonly IConfigProvider _configProvider;
        private readonly Config _config;

        public ConfigService(
            IConfigProvider configProvider)
        {
            _configProvider = configProvider;
            _config = _configProvider.Config;
        }

        public Config Config => _config;
        public FuelConsumptionConfig FuelConsumptionConfig => _config.FuelConsumptionConfig;
        public FuelConsumptionData[] FuelConsumptionData => _config.FuelConsumptionConfig.FuelConsumptionData;
        public FuelConsumptionUnits CurrentFuelConsumptionUnit => _config.FuelConsumptionConfig.CurrentFuelConsumptionUnit;
        public CurrencyConfig CurrencyConfig => _config.CurrencyConfig;
        public CurrencyData[] CurrencyData => _config.CurrencyConfig.CurrencyData;
        public CurrencyUnits CurrentCurrencyUnit => _config.CurrencyConfig.CurrentCurrencyUnit;
        public SpeedConfig SpeedConfig => _config.SpeedConfig;
        public SpeedData[] SpeedData => _config.SpeedConfig.SpeedData;
        public SpeedUnits CurrentSpeedUnit => _config.SpeedConfig.CurrentSpeedUnit;
        public TaxiStationConfig TaxiStationConfig => _config.TaxiStationConfig;
        public int TaxiStationSize => _config.TaxiStationConfig.TaxiStationSize;
        public VolumeConfig VolumeConfig => _config.VolumeConfig;
        public VolumeData[] VolumeData => _config.VolumeConfig.VolumeData;
        public VolumeUnits CurrentVolumeUnit => _config.VolumeConfig.CurrentVolumeUnit;
        public WeightConfig WeightConfig => _config.WeightConfig;
        public WeightData[] WeightData => _config.WeightConfig.WeightData;
        public WeightUnits CurrentWeightUnit => _config.WeightConfig.CurrentWeightUnit;
    }
}
