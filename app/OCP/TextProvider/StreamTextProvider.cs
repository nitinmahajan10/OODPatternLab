using System;
using System.IO;

namespace OODPatternLab.OCP.TextProvider
{
    public class StreamTextProvider : ITextProvider
    {
        private TextReader _readerStream;

        public bool HasMoreText { get; private set; }

        public StreamTextProvider(string filePath) : this (File.OpenText(filePath))
        {
        }

        public StreamTextProvider(TextReader reader)
        {
            _readerStream = reader;
            HasMoreText = true;
        }
        
        public string ReadNext()
        {
            string theLine = _readerStream.ReadLine();
            HasMoreText = theLine != null;            
            return theLine;
        }

        #region IDisposable
        private bool disposedValue = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (_readerStream != null)
                    _readerStream.Dispose();

                disposedValue = true;
            }
        }

        ~StreamTextProvider()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
