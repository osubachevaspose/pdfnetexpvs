// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Bookmarks
{
    public class CreateBookmarkPageRange
    {
        public static void Run()
        {
            // ExStart:CreateBookmarkPageRange
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Bookmarks();

            // Open document
            PdfBookmarkEditor bookmarkEditor = new PdfBookmarkEditor();
            bookmarkEditor.BindPdf( dataDir + "CreateBookmark-Page.pdf");
            // Bookmark name list
            string[] bookmarkList = { "First" };
            // Page list
            int[] pageList = { 1 };
            // Create bookmark of a range of pages
            bookmarkEditor.CreateBookmarkOfPage(bookmarkList, pageList);
            // Save updated PDF file
            bookmarkEditor.Save( dataDir + "CreateBookmarkPageRange_out.pdf");          
            // ExEnd:CreateBookmarkPageRange
        }
    }
}