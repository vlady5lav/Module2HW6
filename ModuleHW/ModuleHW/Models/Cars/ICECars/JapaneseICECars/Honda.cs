namespace ModuleHW
{
    public abstract class Honda : JapaneseICECars
    {
        public Honda()
        {
            Manufacturer = CarManufacturers.Honda;
            ManufacturingCountry = CarManufacturingCountries.Japan;
        }
    }
}
