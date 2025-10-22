// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Pages.MakeNUp
{
    public class UsingPageSizeHorizontalAndVerticalValues
    {
        public static void Run()
        {
            // ExStart:UsingPageSizeHorizontalAndVerticalValues
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Pages();

            // Create PdfFileEditor object
            PdfFileEditor pdfEditor = new PdfFileEditor();
            // Make NUp
            pdfEditor.MakeNUp(dataDir + "input.pdf", "UsingPageSizeHorizontalAndVerticalValues_out.pdf", 2, 3);
            // ExEnd:UsingPageSizeHorizontalAndVerticalValues
        }
    }
}