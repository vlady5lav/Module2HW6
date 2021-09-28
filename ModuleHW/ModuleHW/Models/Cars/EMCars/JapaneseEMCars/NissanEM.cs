namespace ModuleHW
{
    public abstract class NissanEM : JapaneseEMCar
    {
        public NissanEM()
        {
            Manufacturer = CarManufacturers.Nissan;
            ManufacturingCountry = CarManufacturingCountries.Japan;
        }
    }
}
