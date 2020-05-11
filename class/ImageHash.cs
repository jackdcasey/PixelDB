using System;
using System.Security.Cryptography;

using OpenCvSharp;

namespace PixelDB
{
    public class ImageHash
    {
        public static string GetImageHash(string imagePath)
        {
            Mat src = new Mat(imagePath, ImreadModes.AnyColor);
            Mat res = src.Resize(new Size(25, 25));

            byte[] flattened = new byte[res.Height * res.Width * 3];

            int count = 0;
            for (var row = 0; row < res.Rows; row++)
            {
                for (var col = 0; col < res.Cols; col++)
                {
                    Vec3b pixel = Utility.RoundVec3b(res.At<Vec3b>(row, col), 8);

                    flattened[count++] = pixel.Item0;
                    flattened[count++] = pixel.Item1;
                    flattened[count++] = pixel.Item2;
                }
            }

            return Convert.ToBase64String(flattened);
        }
    }
}