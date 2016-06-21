using System;
using System.Text;

namespace OODPatternLab.OCP.TextProvider
{
    public class ConsoleTextProvider : ITextProvider
    {
        public bool HasMoreText { get; private set; }
        
        public ConsoleTextProvider()
        {
            HasMoreText = true;
        }

        public void Dispose()
        {
            //nothing to dispose
        }

        public string ReadNext()
        {
            var strLine = Console.ReadLine();
            HasMoreText = !strLine.Equals("exit", StringComparison.OrdinalIgnoreCase);

            if (!HasMoreText)
                return string.Empty;

            return strLine;
        }
    }
}
