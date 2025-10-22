// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Bookmarks
{
    public class CreateBookmarksAll
    {
        public static void Run()
        {
            // ExStart:CreateBookmarksAll
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Bookmarks();
            // Open document
            PdfBookmarkEditor bookmarkEditor = new PdfBookmarkEditor();
            bookmarkEditor.BindPdf(dataDir+ "CreateBookmarksAll.pdf");
            // Create bookmark of all pages
            bookmarkEditor.CreateBookmarks();
            // Save updated PDF file
            bookmarkEditor.Save(dataDir+ "Output_out.pdf");
            // ExEnd:CreateBookmarksAll
        }
    }
}