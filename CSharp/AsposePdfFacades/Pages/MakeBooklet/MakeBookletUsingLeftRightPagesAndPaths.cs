// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Pages.MakeBooklet
{
    public class MakeBookletUsingLeftRightPagesAndPaths
    {
        public static void Run()
        {
            // ExStart:MakeBookletUsingLeftRightPagesAndPaths
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Pages();

            // Create PdfFileEditor object
            PdfFileEditor pdfEditor = new PdfFileEditor();
            // Set left and right pages
            int[] leftPages = new int[] { 1, 5};
            int[] rightPages = new int[] { 2, 3 };
            // Make booklet
            pdfEditor.MakeBooklet(dataDir + "MultiplePages.pdf", dataDir + "MakeBookletUsingLeftRightPagesAndPaths_out.pdf", leftPages, rightPages);
            // ExEnd:MakeBookletUsingLeftRightPagesAndPaths
        }
    }
}