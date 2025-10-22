// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Bookmarks
{
    public class DeleteAllBookmarks
    {
        public static void Run()
        {
            // ExStart:DeleteAllBookmarks
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Bookmarks();
            // Open document
            PdfBookmarkEditor bookmarkEditor = new PdfBookmarkEditor();
            bookmarkEditor.BindPdf(dataDir+ "DeleteAllBookmarks.pdf");
            // Delete bookmark
            bookmarkEditor.DeleteBookmarks();
            // Save updated PDF file
            bookmarkEditor.Save(dataDir+ "DeleteAllBookmarks_out.pdf");
            // ExEnd:DeleteAllBookmarks
            
        }
    }
}