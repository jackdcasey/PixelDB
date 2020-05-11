using System;

using Xunit;
using OpenCvSharp;

namespace PixelDB
{
    public class UtilityTest
    {
        [Fact]

        public void RoundDouble()
        {
            Assert.Equal(128, Utility.RoundDouble(125, 256, 8, 255));
            Assert.Equal(0, Utility.RoundDouble(64, 256, 2, 255));
            Assert.Equal(128, Utility.RoundDouble(128, 256, 2, 255));

            Assert.Equal(255, Utility.RoundDouble(250, 256, 2, 255));
            Assert.Equal(256, Utility.RoundDouble(256, 256, 2, 256));

            Assert.Throws<ArgumentException>(() => Utility.RoundDouble(0, 255, 8, 255));
        }

        [Fact]
        public void RoundVec3b()
        {
            Assert.Equal(new Vec3b(128, 255, 0), Utility.RoundVec3b(new Vec3b(126, 250, 10), 8));
            Assert.Equal(new Vec3b(255, 255, 255), Utility.RoundVec3b(new Vec3b(200, 200, 200), 2));
            Assert.Equal(new Vec3b(0, 0, 0), Utility.RoundVec3b(new Vec3b(63, 63, 63), 2));
            Assert.Equal(new Vec3b(64, 64, 64), Utility.RoundVec3b(new Vec3b(64, 64, 64), 4));
        }
    }
}
