using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentenceFormator
{
    public class ParagraphAnalyzer
    {
        public int WordCount(string paragraph)
        {
            if (string.IsNullOrWhiteSpace(paragraph)) return 0;

            string[] words = paragraph.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }

        public string LongestWord(string paragraph)
        {
            if (string.IsNullOrWhiteSpace(paragraph)) return string.Empty;

            string[] words = paragraph.Split(new[] { ' ', '\t', '\n', '\r', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            return words.OrderByDescending(w => w.Length).FirstOrDefault();
        }

        public string ReplaceWord(string paragraph, string oldWord, string newWord)
        {
            if (string.IsNullOrWhiteSpace(paragraph)) return string.Empty;

            return System.Text.RegularExpressions.Regex.Replace(
                paragraph,
                $@"\b{System.Text.RegularExpressions.Regex.Escape(oldWord)}\b",
                newWord,
                System.Text.RegularExpressions.RegexOptions.IgnoreCase);
        }

    }
}
