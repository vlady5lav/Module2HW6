using System;

namespace ModuleHW
{
    public static class SearchExtension
    {
        public static Car[] SearchByName(this Car[] cars, string name)
        {
            CarsCheck(cars);

            var indexes = new int[cars.Length];
            var cycle = 0;
            var lastindex = 0;

            foreach (var car in cars)
            {
                if ((car.Manufacturer.ToString() + car.Model.ToString()).Contains(name))
                {
                    indexes[lastindex] = cycle;
                    lastindex++;
                }

                cycle++;
            }

            return GetFiltered(cars, indexes, lastindex);
        }

        public static Car[] SearchByBodyType(this Car[] cars, CarBodyTypes bodyType)
        {
            CarsCheck(cars);

            var indexes = new int[cars.Length];
            var cycle = 0;
            var lastindex = 0;

            foreach (var car in cars)
            {
                if (car.BodyType == bodyType)
                {
                    indexes[lastindex] = cycle;
                    lastindex++;
                }

                cycle++;
            }

            return GetFiltered(cars, indexes, lastindex);
        }

        public static Car[] SearchByEngineType(this Car[] cars, CarEngineTypes engineType1, CarEngineTypes engineType2)
        {
            CarsCheck(cars);

            var indexes = new int[cars.Length];
            var cycle = 0;
            var lastindex = 0;

            foreach (var car in cars)
            {
                if (car.EngineType == engineType1 || car.EngineType == engineType2)
                {
                    indexes[lastindex] = cycle;
                    lastindex++;
                }

                cycle++;
            }

            return GetFiltered(cars, indexes, lastindex);
        }

        public static Car[] SearchByEngineType(this Car[] cars, CarEngineTypes engineType)
        {
            CarsCheck(cars);

            var indexes = new int[cars.Length];
            var cycle = 0;
            var lastindex = 0;

            foreach (var car in cars)
            {
                if (car.EngineType == engineType)
                {
                    indexes[lastindex] = cycle;
                    lastindex++;
                }

                cycle++;
            }

            return GetFiltered(cars, indexes, lastindex);
        }

        public static Car SearchByType(this Car[] cars, Type type)
        {
            CarsCheck(cars);

            var indexes = new int[cars.Length];
            var cycle = 0;

            foreach (var car in cars)
            {
                if (car.GetType() == type)
                {
                    return car;
                }

                cycle++;
            }

            return null;
        }

        public static Car[] GetFiltered(Car[] cars, int[] indexes, int lastindex)
        {
            var filteredCars = new Car[lastindex];

            for (var i = 0; i < lastindex; i++)
            {
                filteredCars[i] = cars[indexes[i]];
            }

            return filteredCars.SortByName();
        }

        public static void CarsCheck(Car[] cars)
        {
            if (cars == null)
            {
                Console.WriteLine("There is nothing to search in SearchExtension!");
                return;
            }
        }
    }
}
