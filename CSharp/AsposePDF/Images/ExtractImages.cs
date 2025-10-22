// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
using System.IO;
using Aspose.Pdf;
using System.Drawing.Imaging;
using System;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Images
{
    public class ExtractImages
    {
        public static void Run()
        {
            // ExStart:ExtractImages
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Images();

            // Open document
            Document pdfDocument = new Document(dataDir+ "ExtractImages.pdf");

            // Extract a particular image
            XImage xImage = pdfDocument.Pages[1].Resources.Images[1];

            FileStream outputImage = new FileStream(dataDir + "output.jpg", FileMode.Create);

            // Save output image
            xImage.Save(outputImage, ImageFormat.Jpeg);
            outputImage.Close();

            dataDir = dataDir + "ExtractImages_out.pdf";

            // Save updated PDF file
            pdfDocument.Save(dataDir);
            // ExEnd:ExtractImages
            Console.WriteLine("\nImages extracted successfully.\nFile saved at " + dataDir); 
            
        }
    }
}