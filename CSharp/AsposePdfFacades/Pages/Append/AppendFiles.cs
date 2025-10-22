// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Pages.Append
{
    public class AppendFiles
    {
        public static void Run()
        {
            // ExStart:AppendFiles
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Pages();

            // Create PdfFileEditor object
            PdfFileEditor pdfEditor = new PdfFileEditor();
            // Append file
            pdfEditor.Append(dataDir + "input.pdf", dataDir +  "input2.pdf", 1, 1, dataDir + "AppendFiles_out.pdf");
            // ExEnd:AppendFiles
        }
    }
}