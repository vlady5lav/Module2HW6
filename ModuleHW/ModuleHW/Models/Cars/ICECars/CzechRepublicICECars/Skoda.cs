namespace ModuleHW
{
    public abstract class Skoda : CzechRepublicICECars
    {
        public Skoda()
        {
            Manufacturer = CarManufacturers.Skoda;
            ManufacturingCountry = CarManufacturingCountries.CzechRepublic;
        }
    }
}
