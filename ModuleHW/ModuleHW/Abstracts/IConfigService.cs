namespace ModuleHW
{
    public interface IConfigService
    {
        Config Config { get; }
        CurrencyConfig CurrencyConfig { get; }
        CurrencyData[] CurrencyData { get; }
        CurrencyUnits? CurrentCurrencyUnit { get; }
        FuelConsumptionConfig FuelConsumptionConfig { get; }
        FuelConsumptionData[] FuelConsumptionData { get; }
        FuelConsumptionUnits? CurrentFuelConsumptionUnit { get; }
        int? TaxiStationSize { get; }
        MileageConfig MileageConfig { get; }
        MileageData[] MileageData { get; }
        SpeedConfig SpeedConfig { get; }
        SpeedData[] SpeedData { get; }
        SpeedUnits? CurrentSpeedUnit { get; }
        TaxiStationConfig TaxiStationConfig { get; }
        VolumeConfig VolumeConfig { get; }
        VolumeData[] VolumeData { get; }
        VolumeUnits? CurrentVolumeUnit { get; }
        WeightConfig WeightConfig { get; }
        WeightData[] WeightData { get; }
        WeightUnits? CurrentWeightUnit { get; }
    }
}