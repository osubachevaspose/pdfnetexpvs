// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Pages.SplitPages
{
    public class SplitPagesUsingPaths
    {
        public static void Run()
        {
            // ExStart:SplitPagesUsingPaths
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Pages();

            // Create PdfFileEditor object
            PdfFileEditor pdfEditor = new PdfFileEditor();
            // Split pages
            pdfEditor.SplitFromFirst(dataDir + "MultiplePages.pdf", 3, dataDir + "SplitPagesUsingPaths_out.pdf");
            // ExEnd:SplitPagesUsingPaths
        }
    }
}