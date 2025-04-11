using System;
using UnitTests;

namespace Task1.Tests;

public class TextManipulatorCompressionTest : CompressionTest<TextManipulator>
{
    public override TextManipulator CreateInstance()
    {
        return new TextManipulator();
    }
}
