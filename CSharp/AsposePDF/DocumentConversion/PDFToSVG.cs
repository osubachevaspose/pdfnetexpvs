// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.DocumentConversion
{
    public class PDFToSVG
    {
        public static void Run()
        {
            // ExStart:PDFToSVG
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_DocumentConversion();

            // Load PDF document
            Document doc = new Document(dataDir + "input.pdf");
            // Instantiate an object of SvgSaveOptions
            SvgSaveOptions saveOptions = new SvgSaveOptions();
            // Do not compress SVG image to Zip archive
            saveOptions.CompressOutputToZipArchive = false;
            // Save the output in SVG files
            doc.Save(dataDir + "PDFToSVG_out.svg", saveOptions);
            // ExEnd:PDFToSVG
        }
    }
}