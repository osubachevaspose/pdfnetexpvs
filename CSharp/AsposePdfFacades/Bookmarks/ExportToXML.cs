// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Bookmarks
{
    public class ExportToXML
    {
        public static void Run()
        {
            // ExStart:ExportToXML
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Bookmarks();
            // Create PdfBookmarkEditor object
            PdfBookmarkEditor bookmarkEditor = new PdfBookmarkEditor();
            // Open PDF file
            bookmarkEditor.BindPdf(dataDir+ "ExportToXML.pdf");
            // Export bookmarks
            bookmarkEditor.ExportBookmarksToXML(dataDir+ "bookmarks.xml");
            // Save updated PDF
            bookmarkEditor.Save(dataDir+ "ExportToXML_out.pdf");
            // ExEnd:ExportToXML            
        }
    }
}