// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Pages.SplitPages
{
    public class SplitPagesToEndUsingStreams
    {
        public static void Run()
        {
            // ExStart:SplitPagesToEndUsingStreams
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Pages();

            // Create PdfFileEditor object
            PdfFileEditor pdfEditor = new PdfFileEditor();
            // Create streams
            FileStream inputStream = new FileStream(dataDir + "MultiplePages.pdf", FileMode.Open);
            FileStream outputStream = new FileStream(dataDir + "SplitPagesToEndUsingStreams_out.pdf", FileMode.Create);
            // Split pages
            pdfEditor.SplitToEnd(inputStream, 3, outputStream);
            // ExEnd:SplitPagesToEndUsingStreams
        }
    }
}