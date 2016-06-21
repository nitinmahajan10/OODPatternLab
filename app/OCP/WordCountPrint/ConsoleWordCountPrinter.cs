using System;

namespace OODPatternLab.OCP.WordCountPrint
{
    public class ConsoleWordCountPrinter : IWordCountPrinter
    {
        public void Print(string theWord, double count)
        {
            Console.WriteLine(string.Format("{0} = {1}", theWord, count));
        }
    }
}
