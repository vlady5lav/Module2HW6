namespace ModuleHW
{
    public static class ArrayHelper
    {
        public static void ReverseArray(Car[] cars)
        {
            var start = 0;
            var end = cars.Length - 1;

            Car temp;

            while (start < end)
            {
                temp = cars[start];
                cars[start] = cars[end];
                cars[end] = temp;
                start++;
                end--;
            }
        }

        public static Car[] CleanCapacity(Car[] cars)
        {
            var count = 0;

            foreach (var item in cars)
            {
                if (item != null)
                {
                    count++;
                }
            }

            var result = new Car[count];

            foreach (var item in cars)
            {
                if (item != null)
                {
                    result[--count] = item;
                }
            }

            ReverseArray(result);

            return result;
        }
    }
}
