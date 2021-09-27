namespace ModuleHW
{
    public abstract class Citroen : FrenchICECars
    {
        public Citroen()
        {
            Manufacturer = CarManufacturers.Citroen;
            ManufacturingCountry = CarManufacturingCountries.France;
        }
    }
}
