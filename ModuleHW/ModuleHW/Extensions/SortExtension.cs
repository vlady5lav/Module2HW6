using System;
using System.Collections;

namespace ModuleHW
{
    public static class SortExtension
    {
        private static readonly NameComparer _nameComparer;
        private static readonly PriceComparer _priceComparer;
        private static readonly WeightComparer _weightComparer;

        static SortExtension()
        {
            _nameComparer = new NameComparer();
            _priceComparer = new PriceComparer();
            _weightComparer = new WeightComparer();
        }

        public static void SortByName(this Car[] cars)
        {
            SortCheck(cars);
            Array.Sort(cars, _nameComparer);
        }

        public static void SortByPrice(this Car[] cars)
        {
            SortCheck(cars);
            Array.Sort(cars, _priceComparer);
        }

        public static void SortByWeight(this Car[] cars)
        {
            SortCheck(cars);
            Array.Sort(cars, _weightComparer);
        }

        public static void SortByChoose(this Car[] cars, IComparer comparer)
        {
            SortCheck(cars);
            Array.Sort(cars, comparer);
        }

        public static void SortCheck(Car[] cars)
        {
            if (cars.Length == 0)
            {
                Console.WriteLine("There is nothing to sort!");
                return;
            }
        }
    }
}
