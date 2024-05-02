using Android.Content;
using Android.Net;
using AndroidX.Core.Content;
using Microsoft.Maui.Platform;
using ABGroupAppv2;


namespace ABGroupAppv2.Platforms
{
    public class WordDocumentService : IWordDocumentService
    {

        public void OpenWordDocument(string filePath)
        {
            // Get the file URI using FileProvider
            var fileUri = AndroidX.Core.Content.FileProvider.GetUriForFile(
                Platform.CurrentActivity,
                $"{Platform.CurrentActivity.PackageName}.provider",
                new Java.IO.File(filePath));

            // Create an intent to view the Word document
            var intent = new Intent(Intent.ActionView);
            intent.SetDataAndType(fileUri, "application/msword");
            intent.AddFlags(ActivityFlags.NewTask | ActivityFlags.GrantReadUriPermission);

            // Start the activity
            Platform.CurrentActivity.StartActivity(intent);
        }
    }
}
