namespace ModuleHW
{
    public abstract class Tesla : USAICECars
    {
        public Tesla()
        {
            Manufacturer = CarManufacturers.Tesla;
            ManufacturingCountry = CarManufacturingCountries.USA;
        }
    }
}
