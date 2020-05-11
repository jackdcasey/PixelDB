using System;
using System.IO;

using Xunit;

namespace PixelDB
{
    public class PixelDBTest
    {
        [Fact]
        public void CreateFile()
        {
            string testPath = Path.Combine(Path.GetTempPath(), "TestFile.txt");
            string testContent = "Hello World!";

            try
            {
                PixelDB.CreateFile(testPath, testContent);

                Assert.True(File.Exists(testPath), "Check if file is created");
                Assert.Equal(testContent, File.ReadAllText(testPath));
            }
            finally
            {
                File.Delete(testPath);
            }
        }
    }
}
