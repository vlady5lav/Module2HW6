namespace ModuleHW
{
    public abstract class Subaru : JapaneseICECars
    {
        public Subaru()
        {
            Manufacturer = CarManufacturers.Subaru;
            ManufacturingCountry = CarManufacturingCountries.Japan;
        }
    }
}
