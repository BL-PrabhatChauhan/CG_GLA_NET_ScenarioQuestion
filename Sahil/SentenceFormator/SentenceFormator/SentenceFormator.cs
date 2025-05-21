using System;
using System.Text;
using System.Globalization;

namespace SentenceFormator
{
    public class SentenceFormator
    {
        public string TextEditingTool(string paragraph)
        {
            if (string.IsNullOrWhiteSpace(paragraph))
                return string.Empty;

            paragraph = paragraph.Trim(); // Remove leading/trailing spaces

            StringBuilder result = new StringBuilder();
            bool capitalizeNext = true;

            for (int i = 0; i < paragraph.Length; i++)
            {
                char current = paragraph[i];

                if (char.IsWhiteSpace(current))
                {
                    // Avoid multiple spaces
                    if (result.Length > 0 && result[result.Length - 1] != ' ')
                        result.Append(' ');
                    continue;
                }

                if (".!?".Contains(current))
                {
                    result.Append(current);

                    // Ensure one space after punctuation
                    if (i + 1 < paragraph.Length && paragraph[i + 1] != ' ')
                        result.Append(' ');

                    capitalizeNext = true;
                }
                else
                {
                    if (capitalizeNext && char.IsLetter(current))
                    {
                        result.Append(char.ToUpper(current));
                        capitalizeNext = false;
                    }
                    else
                    {
                        result.Append(char.ToLower(current));
                    }
                }
            }

            return result.ToString().Trim();
        }
    }
}
