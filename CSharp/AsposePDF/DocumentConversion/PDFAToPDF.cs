// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.DocumentConversion
{
    public class PDFAToPDF
    {
        public static void Run()
        {
            // ExStart:PDFAToPDF
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_DocumentConversion();

            // Open document
            Document doc = new Document(dataDir + "PDFAToPDF.pdf");

            // Remove PDF/A compliance information
            doc.RemovePdfaCompliance();
            // Save updated document 
            doc.Save(dataDir + "PDFAToPDF_out.pdf");
            // ExEnd:PDFAToPDF
            
        }
    }
}