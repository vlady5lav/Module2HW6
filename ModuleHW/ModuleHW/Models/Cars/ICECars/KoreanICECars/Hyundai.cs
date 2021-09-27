namespace ModuleHW
{
    public abstract class Hyundai : KoreanICECars
    {
        public Hyundai()
        {
            Manufacturer = CarManufacturers.Hyundai;
            ManufacturingCountry = CarManufacturingCountries.Korea;
        }
    }
}
