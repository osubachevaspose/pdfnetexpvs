// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
using System.IO;
using System;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Attachments
{
    public class DeleteAllAttachments
    {
        public static void Run()
        {
            // ExStart:DeleteAllAttachments
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Attachments();

            // Open document
            Document pdfDocument = new Document(dataDir + "DeleteAllAttachments.pdf");

            // Delete all attachments
            pdfDocument.EmbeddedFiles.Delete();

            dataDir = dataDir + "DeleteAllAttachments_out.pdf";

            // Save updated file
            pdfDocument.Save(dataDir);
            // ExEnd:DeleteAllAttachments
            Console.WriteLine("\nAll attachments deleted successfully.\nFile saved at " + dataDir);
        }
    }
}