using System.Text;

namespace OODPatternLab.OCP.WordCountPrint
{
    public class StringWordCountPrinter : IWordCountPrinter
    {
        StringBuilder _strBuilder = new StringBuilder();
        public string PrintedText { get { return _strBuilder.ToString(); } }

        public void Print(string theWord, double count)
        {
            _strBuilder.AppendLine(string.Format("{0}={1}", theWord, count));
        }
    }
}
