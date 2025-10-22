// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Pages.InsertPages
{
    public class InsertPagesUsingStreams
    {
        public static void Run()
        {
            // ExStart:InsertPagesUsingStreams
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Pages();

            // Create PdfFileEditor object
            PdfFileEditor pdfEditor = new PdfFileEditor();
            // Create streams
            FileStream inputStream = new FileStream( dataDir + "MultiplePages.pdf", FileMode.Open);
            FileStream portStream = new FileStream(dataDir + "InsertPages.pdf", FileMode.Open);
            FileStream outputStream = new FileStream(dataDir + "InsertPagesUsingStreams_out.pdf", FileMode.Create);
            int[] pagesToInsert = new int[] { 2, 3 };
            // Insert pages
            pdfEditor.Insert(inputStream, 1, portStream, pagesToInsert, outputStream);
            // ExEnd:InsertPagesUsingStreams
        }
    }
}