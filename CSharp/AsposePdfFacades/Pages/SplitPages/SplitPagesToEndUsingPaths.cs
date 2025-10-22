// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Pages.SplitPages
{
    public class SplitPagesToEndUsingPaths
    {
        public static void Run()
        {
            // ExStart:SplitPagesToEndUsingPaths
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Pages();

            // Create PdfFileEditor object
            PdfFileEditor pdfEditor = new PdfFileEditor();
            // Split pages
            pdfEditor.SplitToEnd(dataDir + "MultiplePages.pdf", 3, dataDir + "SplitPagesToEndUsingPaths_out.pdf");
            // ExEnd:SplitPagesToEndUsingPaths
        }
    }
}