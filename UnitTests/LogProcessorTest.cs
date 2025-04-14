using System;
using Utils;

namespace UnitTests;

public abstract class LogProcessorTest<T> where T : ILogProcessor
{
    public abstract T CreateInstance();

    [Theory]
    [InlineData("10.03.2025 15:14:49.523 INFORMATION Версия программы: '3.4.0.48729'", "2025-03-10\t15:14:49.523\tINFO\tDEFAULT\tВерсия программы: '3.4.0.48729'")]
    [InlineData("2025-03-10 15:14:51.5882|INFO|MobileComputer.GetDeviceId|Код устройства: '@MINDEO-M40-D-410244015546'", "2025-03-10\t15:14:51.5882\tINFO\tMobileComputer.GetDeviceId\tКод устройства: '@MINDEO-M40-D-410244015546'")]
    [InlineData("10.03.2025 15:14:49.523 WRONG Версия программы: '3.4.0.48729'", null)]
    [InlineData("10-03-2025 15:14:49.523 INFO Версия программы: '3.4.0.48729'", null)]
    [InlineData("10.03.2025 15:14:49.523 MISTAKE Версия программы: '3.4.0.48729'", null)]
    [InlineData("2025.03.10 15:14:51.5882|INFO|MobileComputer.GetDeviceId|Код устройства: '@MINDEO-M40-D-410244015546'", null)]
    [InlineData("2025-03-10 15:14:51.5882\tINFO\tMobileComputer.GetDeviceId\tКод устройства: '@MINDEO-M40-D-410244015546'", null)]
    public void ProcessString(string input, string? desiredResult)
    {
        ILogProcessor logProcessor = CreateInstance();

        string? result = logProcessor.Process(input);

        Assert.Equal(desiredResult, result);
    }
}
