using System.Text;
using Utils;

namespace Task1;

public class TextManipulator: ICompress, IDecompress
{
    public string Compress(string input)
    {
        if (string.IsNullOrEmpty(input) || !Char.IsLetter(input[0]))
        {
            return string.Empty;
        }

        StringBuilder stringBuilder = new();

        char letter = input.First();
        int n = 1;
        for (int i = 1; i < input.Length; i++)
        {
            if (input[i] == letter)
            {
                n++;
                continue;
            }

            stringBuilder.Append(letter);
            letter = input[i];
            if (n > 1)
            {
                stringBuilder.Append(n);
                n = 1;
            }

        }

        stringBuilder.Append(letter);
        if (n > 1)
        {
            stringBuilder.Append(n);
        }

        return stringBuilder.ToString();
    }

    public string Decompress(string output)
    {
        if (string.IsNullOrEmpty(output) || !Char.IsLetter(output[0]))
        {
            return string.Empty;
        }

        StringBuilder stringBuilder = new();

        char letter;
        for (int i = 0; i < output.Length; i++)
        {
            int j = i + 1;
            letter = output[i];
            StringBuilder numbers = new();
            while (j < output.Length && char.IsDigit(output[j]))
            {
                numbers.Append(output[j]);
                j++;
            }
            int count = 1;
            if (numbers.Length >= 1)
                count = Convert.ToInt32(numbers.ToString());

            stringBuilder.Append(new string(letter, count));

            i = j - 1;
        }

        return stringBuilder.ToString();
    }
}
