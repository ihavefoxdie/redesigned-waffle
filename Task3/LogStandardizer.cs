using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using Utils;

namespace Task3;

public class LogStandardizer : ILogProcessor
{
    public string? Process(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return null;
        }

        Regex regex = LogRegex.GetLogRegexNoMethod();
        Match match = regex.Match(input);
        string dateFormat = "dd.MM.yyyy";
        string methodName = "DEFAULT";
        string message = match.Groups[4].Value;
        if (!match.Success)
        {
            regex = LogRegex.GetLogRegex();
            match = regex.Match(input);
            if (!match.Success)
            {
                return null;
            }
            dateFormat = "yyyy-MM-dd";
            methodName = match.Groups[4].Value;
            message = match.Groups[5].Value;
        }

        if (!DateTime.TryParseExact(match.Groups[1].Value, dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date))
        {
            return null;
        }

        string? logLevel = LogLevel(match.Groups[3].Value);

        if(logLevel == null)
        {
            return null;
        }

        StringBuilder stringBuilder = new();
        stringBuilder.Append(date.ToString("yyyy-MM-dd") + "\t");
        stringBuilder.Append(match.Groups[2].Value + "\t");
        stringBuilder.Append(logLevel + "\t");
        stringBuilder.Append(methodName + "\t");
        stringBuilder.Append(message);

        return stringBuilder.ToString();
    }


    private static string? LogLevel(string level)
    {
        if (string.IsNullOrEmpty(level))
        {
            return null;
        }

        if (level != "INFORMATION" && level != "INFO" && level != "WARNING" && level != "WARN" && level != "ERROR" && level != "DEBUG")
        {
            return null;
        }

        if (level == "INFORMATION")
        {
            level = "INFO";
        }
        if (level == "WARNING")
        {
            level = "WARN";
        }

        return level;
    }
}
