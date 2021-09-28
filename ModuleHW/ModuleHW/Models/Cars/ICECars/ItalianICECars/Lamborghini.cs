namespace ModuleHW
{
    public abstract class Lamborghini : ItalianICECars
    {
        public Lamborghini()
        {
            Manufacturer = CarManufacturers.Lamborghini;
            ManufacturingCountry = CarManufacturingCountries.Italy;
        }
    }
}
