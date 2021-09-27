namespace ModuleHW
{
    public interface ICarsService
    {
        Car[] AllCars { get; }

        void CarsCheck(Car[] cars);
    }
}