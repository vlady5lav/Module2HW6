namespace ModuleHW
{
    public abstract class HyundaiEM : KoreanEMCar
    {
        public HyundaiEM()
        {
            Manufacturer = CarManufacturers.Hyundai;
            ManufacturingCountry = CarManufacturingCountries.Korea;
        }
    }
}
