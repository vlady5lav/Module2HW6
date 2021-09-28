namespace ModuleHW
{
    public abstract class Ford : USAICECars
    {
        public Ford()
        {
            Manufacturer = CarManufacturers.Ford;
            ManufacturingCountry = CarManufacturingCountries.USA;
        }
    }
}
