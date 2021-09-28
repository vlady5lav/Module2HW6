using System.Collections;

namespace ModuleHW
{
    public class NameComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            var car1 = x as Car;
            var car2 = y as Car;

            var car1NameChars = (car1.Manufacturer.ToString() + car1.Model.ToString()).ToCharArray();
            var car2NameChars = (car2.Manufacturer.ToString() + car2.Model.ToString()).ToCharArray();

            var length = car1NameChars.Length <= car2NameChars.Length ? car1NameChars.Length : car2NameChars.Length;

            for (var i = 0; i < length; i++)
            {
                if (car1NameChars[i] > car2NameChars[i])
                {
                    return 1;
                }
                else if (car1NameChars[i] < car2NameChars[i])
                {
                    return -1;
                }
            }

            return 0;
        }
    }
}
