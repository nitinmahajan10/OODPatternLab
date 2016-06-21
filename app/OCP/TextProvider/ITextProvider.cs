using System;

namespace OODPatternLab.OCP.TextProvider
{
    public interface ITextProvider : IDisposable
    {
        bool HasMoreText { get; }
        string ReadNext();
    }
}
