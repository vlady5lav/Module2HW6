namespace ModuleHW
{
    public abstract class Renault : FrenchICECars
    {
        public Renault()
        {
            Manufacturer = CarManufacturers.Renault;
            ManufacturingCountry = CarManufacturingCountries.France;
        }
    }
}
