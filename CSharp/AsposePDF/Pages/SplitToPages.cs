// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Pages
{
    public class SplitToPages
    {
        public static void Run()
        {
            // ExStart:SplitToPages
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Pages();
            
            // Open document
            Document pdfDocument = new Document(dataDir + "SplitToPages.pdf");

            int pageCount = 1;

            // Loop through all the pages
            foreach (Page pdfPage in pdfDocument.Pages)
            {
                Document newDocument = new Document();
                newDocument.Pages.Add(pdfPage);
                newDocument.Save(dataDir + "page_" + pageCount + "_out" + ".pdf");
                pageCount++;
            }
            // ExEnd:SplitToPages       
         
        }
    }
}