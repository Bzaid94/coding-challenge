using System.Text;

namespace CodingChallenge;

public class OldPhonePad
{
    // Mapping from digit to corresponding characters on a phone keypad.
    private static readonly Dictionary<char, string> DigitToCharacters = new()
    {
        {'2', "abc"}, {'3', "def"},
        {'4', "ghi"}, {'5', "jkl"}, {'6', "mno"},
        {'7', "pqrs"}, {'8', "tuv"}, {'9', "wxyz"},
    };

    /// <summary>
    /// Converts the given sequence of digits to text based on old phone keypad rules.
    /// </summary>
    /// <param name="input">The sequence of digits as a string. Can include spaces, # for end, * for backspace.</param>
    /// <returns>The corresponding text.</returns>
    /// <exception cref="ArgumentException">Thrown when input contains unexpected characters.</exception>
    public string ConvertToText(string input)
    {
        var result = new StringBuilder();
        var count = 0;
        char? lastDigit = null;

        foreach (var currentChar in input)
        {
            if (currentChar == ' ' || currentChar == '#' || currentChar == '*')
            {
                if (lastDigit != null)
                {
                    AppendCorrespondingCharacter(result, lastDigit.Value, count);
                }

                switch (currentChar)
                {
                    case '#':
                        return result.ToString();
                    case '*':
                        RemoveLastCharacter(result);
                        break;
                }

                lastDigit = null;
            }
            else
            {
                if (!DigitToCharacters.ContainsKey(currentChar))
                {
                    throw new ArgumentException($"Unexpected character '{currentChar}' in input.");
                }

                // Handle case where a new digit is encountered
                if (lastDigit != currentChar)
                {
                    if (lastDigit != null)
                    {
                        AppendCorrespondingCharacter(result, lastDigit.Value, count);
                    }

                    lastDigit = currentChar;
                    count = 1;
                }
                else
                {
                    count++;
                }
            }
        }

        return result.ToString();
    }
    private static void AppendCorrespondingCharacter(StringBuilder result, char lastDigit, int count)
    {
        result.Append(DigitToCharacters[lastDigit][(count - 1) % DigitToCharacters[lastDigit].Length]);
    }

    private static void RemoveLastCharacter(StringBuilder result)
    {
        if (result.Length > 0)
        {
            result.Length--;
        }
    }
}