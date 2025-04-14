using UnitTests;
using Utils;

namespace Task3.Tests;

public class LogStandardizerTest : LogProcessorTest<LogStandardizer>
{
    public override LogStandardizer CreateInstance()
    {
        return new LogStandardizer();
    }
}
