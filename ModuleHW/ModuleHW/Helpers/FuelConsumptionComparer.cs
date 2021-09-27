using System.Collections;

namespace ModuleHW
{
    public class FuelConsumptionComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            var car1 = x as ICECar;
            var car2 = y as ICECar;

            if (!(x is ICECar || x is HybridCar))
            {
                return -1;
            }

            if (!(y is ICECar || y is HybridCar))
            {
                return 1;
            }

            if (car1.FuelConsumption > car2.FuelConsumption)
            {
                return 1;
            }
            else if (car1.FuelConsumption < car2.FuelConsumption)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
