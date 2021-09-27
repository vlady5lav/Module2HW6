namespace ModuleHW
{
    public abstract class Peugeot : FrenchICECars
    {
        public Peugeot()
        {
            Manufacturer = CarManufacturers.Peugeot;
            ManufacturingCountry = CarManufacturingCountries.France;
        }
    }
}
