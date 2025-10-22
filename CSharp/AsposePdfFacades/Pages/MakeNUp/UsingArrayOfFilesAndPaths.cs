// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Pages.MakeNUp
{
    public class UsingArrayOfFilesAndPaths
    {
        public static void Run()
        {
            // ExStart:UsingArrayOfFilesAndPaths
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Pages();

            // Create PdfFileEditor object
            PdfFileEditor pdfEditor = new PdfFileEditor();
            // Create array of files
            string[] filesArray = new string[2];
            filesArray[0] =  dataDir + "input.pdf";
            filesArray[1] = dataDir + "input2.pdf";
            // Make NUp
            pdfEditor.MakeNUp(filesArray, dataDir + "UsingArrayOfFilesAndPaths_out.pdf", true);
            // ExEnd:UsingArrayOfFilesAndPaths
        }
    }
}