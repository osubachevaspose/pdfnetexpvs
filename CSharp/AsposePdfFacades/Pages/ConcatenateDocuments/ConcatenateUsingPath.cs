// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Pages.ConcatenateDocuments
{
    public class ConcatenateUsingPath
    {
        public static void Run()
        {
            // ExStart:ConcatenateUsingPath
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Pages();
            // Create PdfFileEditor object
            PdfFileEditor pdfEditor = new PdfFileEditor();
            // Concatenate files
            pdfEditor.Concatenate(dataDir + "input.pdf", dataDir + "input2.pdf", dataDir + "ConcatenateUsingPath_out.pdf");
            // ExEnd:ConcatenateUsingPath
        }
        public static void CopyOutline()
        {
            // ExStart:CopyOutline
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Pages();

            PdfFileEditor pfe = new PdfFileEditor();
            string[] files = Directory.GetFiles(dataDir);
            pfe.CopyOutlines = false;
            pfe.Concatenate(files, dataDir + "CopyOutline_out.pdf");
            // ExEnd:CopyOutline
 
        }
    }
}