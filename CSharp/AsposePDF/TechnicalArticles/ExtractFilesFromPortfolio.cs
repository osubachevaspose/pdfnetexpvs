// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
using System.IO;
using System;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.TechnicalArticles
{
    public class ExtractFilesFromPortfolio
    {
        public static void Run()
        {
            // ExStart:ExtractFilesFromPortfolio
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_TechnicalArticles();

            // Load source PDF Portfolio
            Aspose.Pdf.Document pdfDocument = new Aspose.Pdf.Document(dataDir + "PDFPortfolio.pdf");
            // Get collection of embedded files
            EmbeddedFileCollection embeddedFiles = pdfDocument.EmbeddedFiles;
            // Itterate through individual file of Portfolio
            foreach (FileSpecification fileSpecification in embeddedFiles)
            {
                // Get the attachment and write to file or stream
                byte[] fileContent = new byte[fileSpecification.Contents.Length];
                fileSpecification.Contents.Read(fileContent, 0, fileContent.Length);
                string filename = Path.GetFileName(fileSpecification.Name);
                // Save the extracted file to some location
                FileStream fileStream = new FileStream(dataDir + "_out" + filename, FileMode.Create);
                fileStream.Write(fileContent, 0, fileContent.Length);
                // Close the stream object
                fileStream.Close();
            }
            // ExEnd:ExtractFilesFromPortfolio                      
        }
    }
}