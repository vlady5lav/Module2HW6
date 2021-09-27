using System.Collections;

namespace ModuleHW
{
    public class FuelConsumptionComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            var car1 = x as Car;
            var car2 = y as Car;

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
