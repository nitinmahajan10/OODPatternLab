using OODPatternLab.OCP.WordCountPrint;

namespace OODPatternLab.OCP.WordStore
{
    public abstract class WordCountStore
    {
        private readonly IWordCountPrinter ThePrinter;
        protected WordCountStore(IWordCountPrinter wordPrinter, bool caseInsenstive)
        {
            ThePrinter = wordPrinter;
            CaseInsenstive = caseInsenstive;
        }

        public bool CaseInsenstive { get; private set; }
        public abstract void IncrementCount(string theWord);
        public abstract void Print();

        protected void Print(string theWord, double count)
        {
            ThePrinter.Print(theWord, count);
        }

        protected void PrintNoValues()
        {
            Print("No Words in store", 0);
        }
    }
}
