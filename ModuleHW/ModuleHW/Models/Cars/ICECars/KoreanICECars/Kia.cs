namespace ModuleHW
{
    public abstract class Kia : KoreanICECars
    {
        public Kia()
        {
            Manufacturer = CarManufacturers.Kia;
            ManufacturingCountry = CarManufacturingCountries.Korea;
        }
    }
}
