using System;

using OpenCvSharp;

namespace PixelDB
{
    public class Utility
    {
        public static Double RoundDouble(double input, double max, int steps, double hardLimit)
        {
            if (max % steps != 0) throw new ArgumentException("Max must be divisible by steps");

            double minDiff = double.PositiveInfinity;
            double minValue = double.PositiveInfinity;

            for (int i = 0; i < steps + 1; i++)
            {
                double difference = Math.Abs(input - (i * (max / steps)));

                if (difference < minDiff)
                {
                    minDiff = difference;
                    minValue = i * (max / steps);
                }
            }

            return Math.Min(minValue, hardLimit);
        }

        public static Vec3b RoundVec3b(Vec3b src, int steps)
        {
            src.Item0 = (byte)(int)RoundDouble(src.Item0, 256, steps, 255);
            src.Item1 = (byte)(int)RoundDouble(src.Item1, 256, steps, 255);
            src.Item2 = (byte)(int)RoundDouble(src.Item2, 256, steps, 255);

            return src;
        }
    }
}