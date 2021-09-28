namespace ModuleHW
{
    public abstract class Bugatti : FrenchICECars
    {
        public Bugatti()
        {
            Manufacturer = CarManufacturers.Bugatti;
            ManufacturingCountry = CarManufacturingCountries.France;
        }
    }
}
