// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
using System.IO;
using System;
using Aspose.Pdf;
using Aspose.Pdf.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Pages
{
    public class GetPageCount
    {
        public static void Run()
        {
            // ExStart:GetPageCount
            // Instantiate Document instance
            Document doc = new Document();
            // Add page to pages collection of PDF file
            Page page = doc.Pages.Add();
            // Create loop instance
            for (int i = 0; i < 300; i++)
                // Add TextFragment to paragraphs collection of page object
                page.Paragraphs.Add(new TextFragment("Pages count test"));
            // Process the paragraphs in PDF file to get accurate page count
            doc.ProcessParagraphs();
            // Print number of pages in document
            Console.WriteLine("Number of pages in document = " + doc.Pages.Count);
            // ExEnd:GetPageCount
        }
    }
}