namespace ModuleHW
{
    public abstract class Maserati : ItalianICECars
    {
        public Maserati()
        {
            Manufacturer = CarManufacturers.Maserati;
            ManufacturingCountry = CarManufacturingCountries.Italy;
        }
    }
}
