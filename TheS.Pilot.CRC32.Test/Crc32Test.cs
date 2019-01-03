using System;
using System.Text;
using Xunit;

namespace TheS.Pilot.CRC32.Test
{
    public class Crc32Test
    {
        [Theory]
        [InlineData("Hello world.", 0x8b3a0404)]
        [InlineData("The quick brown fox jumps over the lazy dog", 0x414FA339)]
        [InlineData("CRC is one of the most reliable error detection schemes and can detect up to 95.5% of all errors. The most commonly used code is the CRC-32 standard code which is defined by the CCITT, and will give a 32-bit CRC signature (8 hex characters). This signature is normally appended onto the data, and then checked when the data is read. If the CRC-32 check differs from the stored value, there is likely to be an error in the data.", 0x75247dbf)]
        [InlineData("ÊÇÑÊ´Õ¤¹ä·Â", 0x05399b9e)]
        [InlineData("¡¢¤§", 0x48839247)]
        [InlineData("¢¤§¨", 0x48839247)]
        public void Test1(string text, uint expected)
        {
            var sut = new Crc32Sanity();
            //var bytes = Encoding.UTF8.GetBytes(text);
            var bytes = Encoding.ASCII.GetBytes(text);
            var actual = sut.ComputeChecksum(bytes);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Hello world.", 0x8b3a0404)]
        [InlineData("The quick brown fox jumps over the lazy dog", 0x414FA339)]
        [InlineData("CRC is one of the most reliable error detection schemes and can detect up to 95.5% of all errors. The most commonly used code is the CRC-32 standard code which is defined by the CCITT, and will give a 32-bit CRC signature (8 hex characters). This signature is normally appended onto the data, and then checked when the data is read. If the CRC-32 check differs from the stored value, there is likely to be an error in the data.", 0x75247dbf)]
        [InlineData("ÊÇÑÊ´Õ¤¹ä·Â", 0x05399b9e)]
        [InlineData("¡¢¤§", 0x48839247)]
        [InlineData("¢¤§¨", 0x48839247)]
        public void Test2(string text, uint expected)
        {
            var sut = new Crc32Rosetta();
            //var bytes = Encoding.UTF8.GetBytes(text);
            var bytes = Encoding.ASCII.GetBytes(text);
            var actual = sut.Get(bytes);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Hello world.", 0x8b3a0404)]
        [InlineData("The quick brown fox jumps over the lazy dog", 0x414FA339)]
        [InlineData("CRC is one of the most reliable error detection schemes and can detect up to 95.5% of all errors. The most commonly used code is the CRC-32 standard code which is defined by the CCITT, and will give a 32-bit CRC signature (8 hex characters). This signature is normally appended onto the data, and then checked when the data is read. If the CRC-32 check differs from the stored value, there is likely to be an error in the data.", 0x75247dbf)]
        [InlineData("ÊÇÑÊ´Õ¤¹ä·Â", 0x05399b9e)]
        [InlineData("¡¢¤§", 0x48839247)]
        [InlineData("¢¤§¨", 0x48839247)]
        public void Test3(string text, uint expected)
        {
            var sut = new Crc32Dotnet();
            //var bytes = Encoding.UTF8.GetBytes(text);
            var bytes = Encoding.ASCII.GetBytes(text);
            var actual = sut.Get(bytes);
            Assert.Equal(expected, actual);
        }
    }
}
