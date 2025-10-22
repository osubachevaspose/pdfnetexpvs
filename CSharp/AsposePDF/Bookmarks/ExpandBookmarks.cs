// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Bookmarks
{
    public class ExpandBookmarks
    {
        public static void Run()
        {
            // ExStart:ExpandBookmarks
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Bookmarks();

            // Open document
            Document doc = new Document(dataDir + "input-bookmark.pdf");

            // Set page view mode i.e. show thumbnails, full-screen, show attachment panel
            doc.PageMode = PageMode.UseOutlines;
            // Traverse through each Outline item in outlines collection of PDF file
            foreach (OutlineItemCollection item in doc.Outlines)
            {
                // Set open status for outline item
                item.Open = true;
            }

            dataDir = dataDir + "ExpandBookmarks_out.pdf";
            // Save output
            doc.Save(dataDir);
            // ExEnd:ExpandBookmarks
            Console.WriteLine("\nBookmarks expanded successfully.\nFile saved at " + dataDir);

        }
    }
}