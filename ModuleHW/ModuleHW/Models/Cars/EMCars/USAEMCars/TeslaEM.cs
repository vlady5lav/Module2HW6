namespace ModuleHW
{
    public abstract class TeslaEM : USAEMCar
    {
        public TeslaEM()
        {
            Manufacturer = CarManufacturers.Tesla;
            ManufacturingCountry = CarManufacturingCountries.USA;
        }
    }
}
