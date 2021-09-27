using System;

namespace ModuleHW
{
    public static class SearchExtension
    {
        public static Car[] Search(this Car[] cars, string name)
        {
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

        public static Car[] Search(this Car[] cars, double weight)
        {
            var indexes = new int[cars.Length];
            var cycle = 0;
            var lastindex = 0;

            foreach (var car in cars)
            {
                if (car.Weight <= weight + 100 && car.Weight >= weight - 100)
                {
                    indexes[lastindex] = cycle;
                    lastindex++;
                }

                cycle++;
            }

            return GetFiltered(cars, indexes, lastindex);
        }

        public static Car[] Search(Car[] cars, int minMaxSpeed, int maxMaxSpeed)
        {
            var indexes = new int[cars.Length];
            var cycle = 0;
            var lastindex = 0;

            foreach (var car in cars)
            {
                if (car.MaxSpeed >= minMaxSpeed && car.MaxSpeed <= maxMaxSpeed)
                {
                    indexes[lastindex] = cycle;
                    lastindex++;
                }

                cycle++;
            }

            return GetFiltered(cars, indexes, lastindex);
        }

        public static Car[] Search(Car[] cars, int maxSpeed)
        {
            var indexes = new int[cars.Length];
            var cycle = 0;
            var lastindex = 0;

            foreach (var car in cars)
            {
                if (car.MaxSpeed >= maxSpeed)
                {
                    indexes[lastindex] = cycle;
                    lastindex++;
                }

                cycle++;
            }

            return GetFiltered(cars, indexes, lastindex);
        }

        public static Car[] Search(this Car[] cars, CarBodyTypes bodyType)
        {
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

        public static Car[] Search(this Car[] cars, CarEngineTypes engineType1, CarEngineTypes engineType2)
        {
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

        public static Car SearchByType(this Car[] cars, Type type)
        {
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

            filteredCars.SortByName();
            return filteredCars;
        }
    }
}
