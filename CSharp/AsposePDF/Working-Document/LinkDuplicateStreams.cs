// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Working_Document
{
    public class LinkDuplicateStreams
    {
        public static void Run()
        {
            // ExStart:LinkDuplicateStreams
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_WorkingDocuments();
            // Open document
            Document pdfDocument = new Document(dataDir + "OptimizeDocument.pdf");
            // Set LinkDuplicateStreams option 
            var optimizeOptions = new Pdf.Optimization.OptimizationOptions
            {
                LinkDuplicateStreams = true
            };
            // Optimize PDF document using OptimizationOptions
            pdfDocument.OptimizeResources(optimizeOptions);
            dataDir = dataDir + "OptimizeDocument_out.pdf";
            // Save updated document
            pdfDocument.Save(dataDir);
            // ExEnd:LinkDuplicateStreams
            Console.WriteLine("\nLinked duplicate streams successfully.\nFile saved at " + dataDir);
        }
    }
}
