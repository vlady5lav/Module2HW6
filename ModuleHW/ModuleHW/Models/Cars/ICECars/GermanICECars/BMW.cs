namespace ModuleHW
{
    public abstract class BMW : GermanICECars
    {
        public BMW()
        {
            Manufacturer = CarManufacturers.BMW;
            ManufacturingCountry = CarManufacturingCountries.Germany;
        }
    }
}
