// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Pages
{
    public class InsertEmptyPageAtEnd
    {
        public static void Run()
        {
            // ExStart:InsertEmptyPageAtEnd
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Pages();

            // Open document
            Document pdfDocument1 = new Document(dataDir + "InsertEmptyPageAtEnd.pdf");

            // Insert an empty page at the end of a PDF file
            pdfDocument1.Pages.Add();

            dataDir = dataDir + "InsertEmptyPageAtEnd_out.pdf";
            // Save output file
            pdfDocument1.Save(dataDir);
            // ExEnd:InsertEmptyPageAtEnd
            System.Console.WriteLine("\nEmpty page inserted successfully at the end of document.\nFile saved at " + dataDir);

        }
    }
}