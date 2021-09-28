namespace ModuleHW
{
    public abstract class Opel : GermanICECars
    {
        public Opel()
        {
            Manufacturer = CarManufacturers.Opel;
            ManufacturingCountry = CarManufacturingCountries.Germany;
        }
    }
}
