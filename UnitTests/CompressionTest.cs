using Utils;

namespace UnitTests;

public abstract class CompressionTest<T> where T: ICompress
{
    public abstract T CreateInstance();

    [Theory]
    [InlineData("abbceeeeqaa", "ab2ce4qa2")]
    public void CompressString(string input, string desiredResult)
    {
        ICompress compressor = CreateInstance();

        string result = compressor.Compress(input);

        Assert.Equal(desiredResult, result);
    }
}
