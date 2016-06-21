using OODPatternLab.OCP.WordStore;
using System.Text.RegularExpressions;

namespace OODPatternLab.OCP.TextParser
{
    public class WordTextParser :TextParserBase
    {
        public WordTextParser(WordCountStore wordCountStore) : 
            base(wordCountStore)
        {
        }

        public WordTextParser(WordCountStore wordCountStore, char[] wordDelimeters) : 
            base(wordCountStore, wordDelimeters)
        {
        }

        //Remove the special characters to count only pure words and numbers. Example: comma, fullstop 
        protected override string CleanWord(string theWord)
        {
            return Regex.Replace(theWord, "[^a-zA-Z]+", "");
        }
    }
}
