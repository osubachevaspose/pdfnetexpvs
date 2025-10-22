// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Pages.InsertPages
{
    public class InsertPagesBetweenNumbers
    {
        public static void Run()
        {
            // ExStart:InsertPagesBetweenNumbers
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Pages();

            // Create PdfFileEditor object
            PdfFileEditor pdfEditor = new PdfFileEditor();
            // Insert pages
            pdfEditor.Insert(dataDir + "MultiplePages.pdf", 1, dataDir + "InsertPages.pdf", 2, 5,  dataDir + "InsertPagesBetweenNumbers_out.pdf");
            // ExEnd:InsertPagesBetweenNumbers
        }
    }
}