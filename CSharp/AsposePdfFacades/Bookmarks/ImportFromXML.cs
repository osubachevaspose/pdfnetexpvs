// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Bookmarks
{
    public class ImportFromXML
    {
        public static void Run()
        {
            // ExStart:ImportFromXML
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Bookmarks();
            // Create PdfBookmarkEditor class
            PdfBookmarkEditor bookmarkEditor = new PdfBookmarkEditor();
            // Open PDF file
            bookmarkEditor.BindPdf(dataDir+ "ImportFromXML.pdf");
            // Import bookmarks
            bookmarkEditor.ImportBookmarksWithXML(dataDir+ "bookmarks.xml");
            // Save updated PDF file
            bookmarkEditor.Save(dataDir+ "ImportFromXML_out.pdf");
            // ExEnd:ImportFromXML           
            
        }
    }
}