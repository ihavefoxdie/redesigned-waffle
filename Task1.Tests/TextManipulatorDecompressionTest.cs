using UnitTests;
using Utils;

namespace Task1.Tests;

public class TextManipulatorDecompressionTest : DecompressionTest<TextManipulator>
{
    public override TextManipulator CreateInstance()
    {
        return new TextManipulator();
    }
}
