namespace ModuleHW
{
    public abstract class Suzuki : JapaneseICECars
    {
        public Suzuki()
        {
            Manufacturer = CarManufacturers.Suzuki;
            ManufacturingCountry = CarManufacturingCountries.Japan;
        }
    }
}
