using OODPatternLab.OCP.WordStore;
using System.Configuration;

namespace OODPatternLab.OCP.TextParser
{
    public abstract class TextParserBase
    {
        const string WordDelimeterConfigKey = "WordDelimeters";
        readonly char[] _wordDelimeter;
        readonly WordCountStore _wordCountStore;
        
        //by default space, fullstop and comma are word delimiter delimeters
        protected TextParserBase(WordCountStore wordCountStore) : 
            this(wordCountStore, ConfigurationManager.AppSettings[WordDelimeterConfigKey].ToCharArray())
        {
        }

        protected TextParserBase(WordCountStore wordCountStore, char[] wordDelimeters)
        {
            _wordCountStore = wordCountStore;
            _wordDelimeter = wordDelimeters;
        }

        protected abstract string CleanWord(string theWord);

        //Template design pattern (algorithm to count and update word remains same)
        //however the word delimeters and consideration of special characters can vary
        public void UpdateWordCount(string theString)
        {
            if (string.IsNullOrEmpty(theString))
                return;

            var wordArray = theString.Split(_wordDelimeter); //any token sperated by space in front and back is considedred as word

            foreach (string theWord in wordArray)
            {
                var theCleanWord = CleanWord(theWord);

                if (string.IsNullOrWhiteSpace(theCleanWord))
                    continue; //we don't want to count whitespaces as words

                _wordCountStore.IncrementCount(theCleanWord);                
            }
        }
    }
}