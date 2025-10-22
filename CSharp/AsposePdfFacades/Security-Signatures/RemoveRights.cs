// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
using System.IO;
using System;
using System.Drawing.Imaging;
using System.Drawing;
using Aspose.Pdf.Facades;
using System.Collections;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.SecuritySignatures
{
    public class RemoveRights
    {
        public static void Run()
        {
            try
            {
                // ExStart:RemoveRights               
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_AsposePdfFacades_SecuritySignatures();
                string input = dataDir + "DigitallySign.pdf";
                using (PdfFileSignature pdfSign = new PdfFileSignature())
                {
                    pdfSign.BindPdf(input);
                    if (pdfSign.ContainsUsageRights())
                    {
                        pdfSign.RemoveUsageRights();
                    }

                    pdfSign.Document.Save(dataDir + "RemoveRights_out.pdf");
                }
                // ExEnd:RemoveRights
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }       
    }
}