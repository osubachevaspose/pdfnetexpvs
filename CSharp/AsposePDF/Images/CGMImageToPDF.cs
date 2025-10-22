// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
using System;
using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Images
{
    public class CGMImageToPDF
    {
        public static void Run()
        {
            // ExStart:CGMImageToPDF
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Images();

            string inputFile = dataDir + "corvette.cgm";
            dataDir = dataDir + "CGMImageToPDF_out.pdf";
            // Save CGM into PDF format
            PdfProducer.Produce(inputFile, ImportFormat.Cgm, dataDir);
            // ExEnd:CGMImageToPDF
            Console.WriteLine("\nCGM file converted to pdf successfully.\nFile saved at " + dataDir); 
            
        }
        
    }
}