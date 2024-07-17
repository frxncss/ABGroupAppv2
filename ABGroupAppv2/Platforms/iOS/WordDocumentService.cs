using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIKit;

namespace ABGroupAppv2.Platforms
{
    public class WordDocumentService : IWordDocumentService
    {
        public void OpenWordDocument(string filePath)
        {
            // Get the file URL
            var fileUrl = NSUrl.FromFilename(filePath);
            // Create a UIDocumentInteractionController
            var documentController = UIDocumentInteractionController.FromUrl(fileUrl);
            // Present the document interaction controller
            documentController.PresentPreview(true);
        }
    }
}
