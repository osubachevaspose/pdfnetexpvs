// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
using System;
using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;
using System.Drawing;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Images
{
    public class LargeCGMImageToPDF
    {
        public static void Run()
        {
            // ExStart:LargeCGMImageToPDF
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Images();

            string inputFile = dataDir + "corvette.cgm";
            dataDir = dataDir + "LargeCGMImageToPDF_out.pdf";

            // Create an instance of CgmImportOptions
            CgmImportOptions options = new CgmImportOptions();

            // Specify the dimentions for page size import 
            options.PageSize = new SizeF(1000, 1000);

            // Save CGM into PDF format
            PdfProducer.Produce(inputFile, ImportFormat.Cgm, dataDir);
            // ExEnd:LargeCGMImageToPDF
            Console.WriteLine("\nLarge CGM file converted to pdf successfully.\nFile saved at " + dataDir); 
            
        }
        
    }
}