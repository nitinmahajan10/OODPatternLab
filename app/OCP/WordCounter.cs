using OODPatternLab.OCP.TextParser;
using OODPatternLab.OCP.TextProvider;

namespace OODPatternLab.OCP
{
    public class WordCounter
    {
        readonly ITextProvider _textProvider;
        readonly TextParserBase _textParser;

        public WordCounter(ITextProvider textProvider, TextParserBase textParser)
        {
            _textProvider = textProvider;
            _textParser = textParser;
        }
        
        public void Count()
        {
            using (_textProvider)
            {
                while (_textProvider.HasMoreText)
                {
                    _textParser.UpdateWordCount(_textProvider.ReadNext()); 
                }
            }
        }
    }
}
