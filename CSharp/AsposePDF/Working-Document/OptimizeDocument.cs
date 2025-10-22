// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.WorkingDocuments
{
    public class OptimizeDocument
    {
        public static void Run()
        {
            // ExStart:OptimizeDocument
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_WorkingDocuments();

            // Open document
            Document pdfDocument = new Document(dataDir + "OptimizeDocument.pdf");

            // Optimize for web
            pdfDocument.Optimize();

            dataDir = dataDir + "OptimizeDocument_out.pdf";

            // Save output document
            pdfDocument.Save(dataDir);
            // ExEnd:OptimizeDocument
            Console.WriteLine("\nDocument optimized successfully for web.\nFile saved at " + dataDir);
        }
    }
}