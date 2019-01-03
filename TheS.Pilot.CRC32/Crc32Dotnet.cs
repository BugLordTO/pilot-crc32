namespace TheS.Pilot.CRC32
{
    /// <summary>
    /// NUGET: https://github.com/force-net/Crc32.NET/blob/develop/Crc32.NET.Tests/ImplementationTest.cs
    /// </summary>
    public class Crc32Dotnet
    {
        public uint Get(byte[] bytes)
        {
            return Force.Crc32.Crc32Algorithm.Compute(bytes);
        }
    }
}
