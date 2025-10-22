// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.DocumentConversion
{
    public class EPUBToPDF
    {
        public static void Run()
        {
            try
            {
                // ExStart:EPUBToPDF
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_AsposePdf_DocumentConversion();

                // Instantiate LoadOption object using EPUB load option
                EpubLoadOptions epubload = new EpubLoadOptions();

                // Create Document object
                Aspose.Pdf.Document pdf = new Aspose.Pdf.Document(dataDir + "EPUBToPDF.epub", epubload);

                // Save the resultant PDF document
                pdf.Save(dataDir + "EPUBToPDF_out.pdf");
                // ExEnd:EPUBToPDF
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}