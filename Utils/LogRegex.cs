using System.Text.RegularExpressions;

namespace Utils;

public partial class LogRegex
{
    [GeneratedRegex(@"^(\d{4}-\d{2}-\d{2})\s+(\d{2}:\d{2}:\d{2}.\d+)[|]+(\w+)[|]+(\S*)[|]+(.*)$")]
    public static partial Regex GetLogRegex ();

    [GeneratedRegex(@"^(\d{2}.\d{2}.\d{4})\s+(\d{2}:\d{2}:\d{2}.\d+)\s+(\w+)\s+(.*)$")]
    public static partial Regex GetLogRegexNoMethod ();
}
