// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Pages.ExtractPages
{
    public class ExtractPagesBetweenTwoNumbersUsingStreams
    {
        public static void Run()
        {
            // ExStart:ExtractPagesBetweenTwoNumbersUsingStreams
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Pages();

            // Create PdfFileEditor object
            PdfFileEditor pdfEditor = new PdfFileEditor();
            // Create streams
            FileStream inputStream = new FileStream(dataDir + "MultiplePages.pdf", FileMode.Open);
            FileStream outputStream = new FileStream(dataDir + "ExtractPagesBetweenTwoNumbers_out.pdf", FileMode.Create);
            // Extract pages
            pdfEditor.Extract(inputStream, 1, 3, outputStream);
            // ExEnd:ExtractPagesBetweenTwoNumbersUsingStreams
        }
    }
}