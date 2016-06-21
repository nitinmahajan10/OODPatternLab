using OODPatternLab.OCP.WordStore;
using System.Text.RegularExpressions;

namespace OODPatternLab.OCP.TextParser
{
    public class AlphaNumericTextParser : TextParserBase
    {
        public AlphaNumericTextParser(WordCountStore wordCountStore) : 
            base(wordCountStore)
        {
        }

        public AlphaNumericTextParser(WordCountStore wordCountStore, char[] wordDelimeters) : 
            base(wordCountStore, wordDelimeters)
        {
        }

        //Remove the special characters to count only pure words and numbers. Example: comma, fullstop 
        protected override string CleanWord(string theWord)
        {
            return Regex.Replace(theWord, "[^0-9a-zA-Z]+", ""); 
        }
    }
}
