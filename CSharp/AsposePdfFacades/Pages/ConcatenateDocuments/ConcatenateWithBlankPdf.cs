// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Pages.ConcatenateDocuments
{
    public class ConcatenateWithBlankPdf
    {
        public static void Run()
        {
            // ExStart:ConcatenateWithBlankPdf
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Pages();

            // Create PdfFileEditor object
            PdfFileEditor pdfEditor = new PdfFileEditor();
            // Concatenate files
            pdfEditor.Concatenate(dataDir + "input.pdf", dataDir + "input2.pdf", dataDir + "blank.pdf", dataDir + "ConcatenateWithBlankPdf_out.pdf");
            // ExEnd:ConcatenateWithBlankPdf
        }       
    }
}