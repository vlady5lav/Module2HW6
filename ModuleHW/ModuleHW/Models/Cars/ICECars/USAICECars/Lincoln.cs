namespace ModuleHW
{
    public abstract class Lincoln : USAICECars
    {
        public Lincoln()
        {
            Manufacturer = CarManufacturers.Lincoln;
            ManufacturingCountry = CarManufacturingCountries.USA;
        }
    }
}
