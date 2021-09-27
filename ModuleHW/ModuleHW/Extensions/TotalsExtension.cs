namespace ModuleHW
{
    public static class TotalsExtension
    {
        public static int GetTotalCount(this Car[] cars)
        {
            var totalCount = 0;

            foreach (var car in cars)
            {
                totalCount += 1;
            }

            return totalCount;
        }

        public static double GetTotalPrice(this Car[] cars)
        {
            double totalPrice = 0.0d;

            foreach (var car in cars)
            {
                totalPrice += car.Price;
            }

            return totalPrice;
        }

        public static double GetTotalWeight(this Car[] cars)
        {
            double totalWeight = 0.0d;

            foreach (var car in cars)
            {
                totalWeight += car.Weight;
            }

            return totalWeight;
        }

        public static int GetTotalUniquesCount(this Car[] cars)
        {
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

            var uniqueCount = cars.Length - duplesCount;
            return uniqueCount;
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

            uniquesArray.SortByName();
            return uniquesArray;
        }
    }
}
