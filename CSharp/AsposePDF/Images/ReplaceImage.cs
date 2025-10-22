// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Images
{
    public class ReplaceImage
    {
        public static void Run()
        {
            // ExStart:ReplaceImage
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Images();

            // Open document
            Document pdfDocument = new Document(dataDir+ "ReplaceImage.pdf");


            // Replace a particular image
            using (FileStream stream = new FileStream(dataDir + "aspose-logo.jpg", FileMode.Open))
            {
                pdfDocument.Pages[1].Resources.Images.Replace(1, stream);
                dataDir = dataDir + "ReplaceImage_out.pdf";
                // Save updated PDF file
                pdfDocument.Save(dataDir);

            }
            // ExEnd:ReplaceImage
            Console.WriteLine("\nImage replaced successfully.\nFile saved at " + dataDir);
        }
    }
}