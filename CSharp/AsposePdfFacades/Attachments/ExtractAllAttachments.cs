// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
using System;
using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Attachments
{
    public class ExtractAllAttachments
    {
        public static void Run()
        {
            // ExStart:ExtractAllAttachments
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Attachments();
            // Open document
            PdfExtractor pdfExtractor = new PdfExtractor();
            pdfExtractor.BindPdf(dataDir+ "ExtractAllAttachments.pdf");

            // Extract attachments
            pdfExtractor.ExtractAttachment();

            // Get extracted attachments
            pdfExtractor.GetAttachment(dataDir);
            // ExEnd:ExtractAllAttachments
            
        }
    }
}