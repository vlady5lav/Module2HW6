namespace ModuleHW
{
    public abstract class PorscheEM : GermanEMCar
    {
        public PorscheEM()
        {
            Manufacturer = CarManufacturers.Porsche;
            ManufacturingCountry = CarManufacturingCountries.Germany;
        }
    }
}
