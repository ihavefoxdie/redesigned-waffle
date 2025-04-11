using Utils;

namespace UnitTests;

public abstract class DecompressionTest<T> where T: IDecompress
{
    public abstract T CreateInstance();

    [Theory]
    [InlineData("ab2ce4qa2", "abbceeeeqaa")]
    public void CompressString(string input, string desiredResult)
    {
        IDecompress compressor = CreateInstance();

        string result = compressor.Decompress(input);

        Assert.Equal(desiredResult, result);
    }
}
