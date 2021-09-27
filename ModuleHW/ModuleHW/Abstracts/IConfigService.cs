namespace ModuleHW
{
    public interface IConfigService
    {
        Config Config { get; }
        CurrencyConfig CurrencyConfig { get; }
        CurrencyData[] CurrencyData { get; }
        CurrencyUnits CurrentCurrencyUnit { get; }
        FuelConsumptionUnits CurrentFuelConsumptionUnit { get; }
        SpeedUnits CurrentSpeedUnit { get; }
        VolumeUnits CurrentVolumeUnit { get; }
        WeightUnits CurrentWeightUnit { get; }
        FuelConsumptionConfig FuelConsumptionConfig { get; }
        FuelConsumptionData[] FuelConsumptionData { get; }
        SpeedConfig SpeedConfig { get; }
        SpeedData[] SpeedData { get; }
        TaxiStationConfig TaxiStationConfig { get; }
        int TaxiStationSize { get; }
        VolumeConfig VolumeConfig { get; }
        VolumeData[] VolumeData { get; }
        WeightConfig WeightConfig { get; }
        WeightData[] WeightData { get; }
    }
}