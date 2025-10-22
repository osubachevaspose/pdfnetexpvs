// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Text;
using System;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Text
{
    public class ExtractTextAll
    {
        public static void Run()
        {
            // ExStart:ExtractTextAll
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Text();

            // Open document
            Document pdfDocument = new Document(dataDir + "ExtractTextAll.pdf");

            // Create TextAbsorber object to extract text
            TextAbsorber textAbsorber = new TextAbsorber();
            // Accept the absorber for all the pages
            pdfDocument.Pages.Accept(textAbsorber);
            // Get the extracted text
            string extractedText = textAbsorber.Text;
            // Create a writer and open the file
            TextWriter tw = new StreamWriter(dataDir + "extracted-text.txt");
            // Write a line of text to the file
            tw.WriteLine(extractedText);
            // Close the stream
            tw.Close();
            // ExEnd:ExtractTextAll          
            
        }
    }
}