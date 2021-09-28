namespace ModuleHW
{
    public abstract class ToyotaHybrid : JapaneseHybridCar
    {
        public ToyotaHybrid()
        {
            Manufacturer = CarManufacturers.Toyota;
            ManufacturingCountry = CarManufacturingCountries.Japan;
        }
    }
}
