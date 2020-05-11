using System;
using System.IO;

using Xunit;

namespace PixelDB
{
    public class ImageHashTest
    {

        [Fact]
        public void GetHash()
        {
            string image1 = "/Users/jackcasey/repos/PixelDB/test/images/rubiks_cube_large.jpg";
            string image2 = "/Users/jackcasey/repos/PixelDB/test/images/rubiks_cube_large.png";

            string hash1 = ImageHash.GetImageHash(image1);
            string hash2 = ImageHash.GetImageHash(image2);

            Assert.Equal(hash1, hash2);
        }
    }
}
