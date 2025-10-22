// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.DocumentConversion
{
    public class PDFToXPS
    {
        public static void Run()
        {
            // ExStart:PDFToXPS
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_DocumentConversion();

            // Load PDF document
            Document pdfDocument = new Document(dataDir + "input.pdf");

            // Instantiate XPS Save options
            Aspose.Pdf.XpsSaveOptions saveOptions = new Aspose.Pdf.XpsSaveOptions();
            
            // Save the XPS document
            pdfDocument.Save("PDFToXPS_out.xps", saveOptions);       
            // ExEnd:PDFToXPS
        }
    }
}