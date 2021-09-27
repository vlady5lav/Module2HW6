namespace ModuleHW
{
    public abstract class Mazda : JapaneseICECars
    {
        public Mazda()
        {
            Manufacturer = CarManufacturers.Mazda;
            ManufacturingCountry = CarManufacturingCountries.Japan;
        }
    }
}
