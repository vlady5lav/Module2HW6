using System.Collections;

namespace ModuleHW
{
    public class MaxSpeedComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            var car1 = x as Car;
            var car2 = y as Car;

            if (car1.MaxSpeed > car2.MaxSpeed)
            {
                return 1;
            }
            else if (car1.MaxSpeed < car2.MaxSpeed)
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
