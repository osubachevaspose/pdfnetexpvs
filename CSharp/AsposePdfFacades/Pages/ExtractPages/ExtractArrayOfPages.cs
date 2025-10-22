// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Pages.ExtractPages
{
    public class ExtractArrayOfPages
    {
        public static void Run()
        {
            // ExStart:ExtractArrayOfPages
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Pages();

            // Create PdfFileEditor object
            PdfFileEditor pdfEditor = new PdfFileEditor();
            int[] pagesToExtract = new int[] { 1, 2 };
            // Extract pages
            pdfEditor.Extract(dataDir + "Extract.pdf", pagesToExtract, dataDir + "ExtractArrayOfPages_out.pdf");
            // ExEnd:ExtractArrayOfPages
        }
    }
}