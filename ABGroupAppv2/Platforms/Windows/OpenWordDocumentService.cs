using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABGroupAppv2.Platforms
{
    public class WordDocumentService : IWordDocumentService
    {
        public void OpenWordDocument(string filePath)
        {
            // Use System.Diagnostics.Process to start the document
            Process.Start(new ProcessStartInfo
            {
                FileName = filePath,
                UseShellExecute = true
            });
        }
    }
}
