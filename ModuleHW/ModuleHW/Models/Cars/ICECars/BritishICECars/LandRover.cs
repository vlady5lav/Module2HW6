namespace ModuleHW
{
    public abstract class LandRover : BritishICECars
    {
        public LandRover()
        {
            Manufacturer = CarManufacturers.LandRover;
            ManufacturingCountry = CarManufacturingCountries.UnitedKingdom;
        }
    }
}
