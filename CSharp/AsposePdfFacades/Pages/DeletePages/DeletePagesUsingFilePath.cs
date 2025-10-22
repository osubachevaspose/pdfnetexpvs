// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Pages.DeletePages
{
    public class DeletePagesUsingFilePath
    {
        public static void Run()
        {
            // ExStart:DeletePagesUsingFilePath
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Pages();

            // Create PdfFileEditor object
            PdfFileEditor pdfEditor = new PdfFileEditor();
            // Array of pages to delete
            int[] pagesToDelete = new int[] { 1, 2};
            // Delete pages
            pdfEditor.Delete(dataDir + "input.pdf", pagesToDelete, dataDir + "DeletePagesUsingFilePath_out.pdf");
            // ExEnd:DeletePagesUsingFilePath
        }
    }
}