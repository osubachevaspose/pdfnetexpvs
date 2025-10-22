// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Pages.SplitPages
{
    public class SplitPagesToBulkUsingPaths
    {
        public static void Run()
        {
            // ExStart:SplitPagesToBulkUsingPaths
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Pages();

            // Create PdfFileEditor object
            PdfFileEditor pdfEditor = new PdfFileEditor();
            int fileNumber = 1;
            // Create array of pages to split
            int[][] numberOfPages = new int[][] { new int[] { 1, 2 }, new int[] { 3, 4 } };
            // Split to bulk
            MemoryStream[] outBuffer = pdfEditor.SplitToBulks(dataDir + "MultiplePages.pdf", numberOfPages);
            // Save individual files
            foreach (MemoryStream aStream in outBuffer)
            {
                FileStream outStream = new FileStream(dataDir + "File_" + fileNumber.ToString() + "_out.pdf", FileMode.Create);
                aStream.WriteTo(outStream);
                outStream.Close();
                fileNumber++;
            }
            // ExEnd:SplitPagesToBulkUsingPaths
        }
    }
}