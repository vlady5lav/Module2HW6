using System;

namespace ModuleHW
{
    public static class RandomHelper
    {
        private static readonly Random _random;

        static RandomHelper()
        {
            _random = new Random();
        }

        public static Random Random => _random;
    }
}
