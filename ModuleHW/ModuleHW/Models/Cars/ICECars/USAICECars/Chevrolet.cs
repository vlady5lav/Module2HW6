namespace ModuleHW
{
    public abstract class Chevrolet : USAICECars
    {
        public Chevrolet()
        {
            Manufacturer = CarManufacturers.Chevrolet;
            ManufacturingCountry = CarManufacturingCountries.USA;
        }
    }
}
