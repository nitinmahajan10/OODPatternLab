using System;
using System.Collections.Generic;
using OODPatternLab.OCP.WordCountPrint;

namespace OODPatternLab.OCP.WordStore
{
    public class InMemoryWordCountStore : WordCountStore
    {
        public InMemoryWordCountStore(IWordCountPrinter wordPrinter, bool caseInsenstive = false) :
            base(wordPrinter, caseInsenstive)
        {
        }

        SortedDictionary<string, double> _wordCountTable;
        
        public override void IncrementCount(string theWord)
        {
            if (_wordCountTable == null)
                _wordCountTable = CaseInsenstive ?
                                   new SortedDictionary<string, double>(StringComparer.OrdinalIgnoreCase) :
                                   new SortedDictionary<string, double>();

            if (_wordCountTable.ContainsKey(theWord))
                _wordCountTable[theWord]++;
            else
                _wordCountTable.Add(theWord, 1);
        }

        public override void Print()
        {
            if (_wordCountTable == null)
            {
                PrintNoValues();
                return;
            }

            foreach (var kvp in _wordCountTable)
            {
                Print(kvp.Key, kvp.Value);
            }
        }
    }
}
