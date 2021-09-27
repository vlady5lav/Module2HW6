using System;

namespace ModuleHW
{
    public static class TotalsExtension
    {
        public static int GetTotalCount(this Car[] cars)
        {
            CarsCheck(cars);

            var totalCount = 0;

            foreach (var car in cars)
            {
                totalCount += 1;
            }

            return totalCount;
        }

        public static double GetTotalPrice(this Car[] cars)
        {
            CarsCheck(cars);

            double totalPrice = 0.0d;

            foreach (var car in cars)
            {
                totalPrice += (double)car.Price;
            }

            return totalPrice;
        }

        public static double GetTotalWeight(this Car[] cars)
        {
            CarsCheck(cars);

            double totalWeight = 0.0d;

            foreach (var car in cars)
            {
                totalWeight += (double)car.Weight;
            }

            return totalWeight;
        }

        public static int GetTotalUniquesCount(this Car[] cars)
        {
            CarsCheck(cars);

            var duplesCount = 0;

            for (var i = 0; i < cars.Length; i++)
            {
                for (var j = i + 1; j < cars.Length; j++)
                {
                    if (cars[i] == cars[j])
                    {
                        duplesCount++;
                        break;
                    }
                }
            }

            return cars.Length - duplesCount;
        }

        /*
         * can't use it because I shouldn't know anout this :D
         *
        public static int GetTotalUniques(this Car[] cars)
        {
            return cars.Distinct().ToArray().Length;
        }
        */

        public static Car[] GetTotalUniquesArray(this Car[] cars)
        {
            CarsCheck(cars);

            var duples = new int[cars.Length];
            var duplesCount = 0;

            for (var i = 0; i < cars.Length; i++)
            {
                for (var j = i + 1; j < cars.Length; j++)
                {
                    if (cars[i] == cars[j])
                    {
                        duples[j] = 1;
                        duplesCount++;
                        break;
                    }
                }
            }

            var uniquesArray = new Car[cars.Length - duplesCount];
            var index = 0;

            for (var i = 0; i < cars.Length; i++)
            {
                if (duples[i] == 0)
                {
                    uniquesArray[index] = cars[i];
                    index++;
                }
            }

            return uniquesArray.SortByName();
        }

        public static void CarsCheck(Car[] cars)
        {
            if (cars.Length == 0)
            {
                Console.WriteLine("There is nothing to calculate in TotalsExtension!");
                return;
            }
        }
    }
}
