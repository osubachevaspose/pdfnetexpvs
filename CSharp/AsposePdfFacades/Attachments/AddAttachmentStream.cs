// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
using System.IO;
using System;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Attachments
{
    public class AddAttachmentStream
    {
        public static void Run()
        {
            // ExStart:AddAttachmentStream
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Attachments();
            // Open document
            PdfContentEditor contentEditor = new PdfContentEditor();
            contentEditor.BindPdf(dataDir+ "AddAttachment-Stream.pdf");

            // Read file into stream (FileStream or MemoryStream)
            FileStream fileStream = new FileStream(dataDir+ "test.txt", FileMode.Open);
            // Add attachment
            contentEditor.AddDocumentAttachment(fileStream, "Attachment Name", "Attachment Description");

            // Save updated PDF
            contentEditor.Save(dataDir+ "AddAttachment-Stream_out.pdf");
            // ExEnd:AddAttachmentStream            
            
        }
    }
}