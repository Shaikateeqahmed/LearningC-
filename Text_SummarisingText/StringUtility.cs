using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_SummarisingText
{
    public class StringUtility
    {
        public static string SummerizeText(string sentence)
        {
            var maxLength = 20;
            var summaryList = new List<string>();

            if (sentence.Length < maxLength)
            {
                return sentence;
            }
            else
            {
                var words = sentence.Split(' ');

                var totalWordsLenght = 0;

                foreach (var word in words)
                {
                    summaryList.Add(word);
                    totalWordsLenght += word.Length + 1;
                    if (totalWordsLenght > maxLength) break;
                }

                return String.Join(" ", summaryList) + "...";

            }
        }
    }
}
