// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Bookmarks
{
    public class UpdateChildBookmarks
    {
        public static void Run()
        {
            // ExStart:UpdateChildBookmarks
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Bookmarks();

            // Open document
            Document pdfDocument = new Document(dataDir + "UpdateChildBookmarks.pdf");

            // Get a bookmark object
            OutlineItemCollection pdfOutline = pdfDocument.Outlines[1];
            
            // Get child bookmark object
            OutlineItemCollection childOutline = pdfOutline[1];
            childOutline.Title = "Updated Outline";
            childOutline.Italic = true;
            childOutline.Bold = true;
            dataDir = dataDir + "UpdateChildBookmarks_out.pdf";            
            // Save output
            pdfDocument.Save(dataDir);
            // ExEnd:UpdateChildBookmarks
            Console.WriteLine("\nChild bookmarks updated successfully.\nFile saved at " + dataDir);
        }
    }
}