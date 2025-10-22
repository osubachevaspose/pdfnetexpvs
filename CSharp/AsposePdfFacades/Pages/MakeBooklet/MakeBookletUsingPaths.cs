// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Pages.MakeBooklet
{
    public class MakeBookletUsingPaths
    {
        public static void Run()
        {
            // ExStart:MakeBookletUsingPaths
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Pages();

            // Create PdfFileEditor object
            PdfFileEditor pdfEditor = new PdfFileEditor();
            // Make booklet
            pdfEditor.MakeBooklet(dataDir + "input.pdf", dataDir + "MakeBookletUsingPaths_out.pdf");
            // ExEnd:MakeBookletUsingPaths
        }
    }
}