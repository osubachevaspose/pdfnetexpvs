// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Bookmarks
{
    public class DeleteParticularBookmark
    {
        public static void Run()
        {
            // ExStart:DeleteParticularBookmark
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Bookmarks();

            // Open document
            Document pdfDocument = new Document(dataDir + "DeleteParticularBookmark.pdf");

            // Delete particular outline by Title
            pdfDocument.Outlines.Delete("Child Outline");

            dataDir = dataDir + "DeleteParticularBookmark_out.pdf";
            // Save updated file
            pdfDocument.Save(dataDir);
            // ExEnd:DeleteParticularBookmark
            Console.WriteLine("\nParticular bookmark deleted successfully.\nFile saved at " + dataDir);

        }
    }
}