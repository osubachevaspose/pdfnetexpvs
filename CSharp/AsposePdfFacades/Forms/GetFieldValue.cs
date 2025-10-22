// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
using System.IO;
using System;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Forms
{
    public class GetFieldValue
    {
        public static void Run()
        {
            // ExStart:GetFieldValue
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Forms();

            Aspose.Pdf.Facades.Form pdfForm = new Aspose.Pdf.Facades.Form();
            // Open Document
            pdfForm.BindPdf(dataDir + "input.pdf");

            // Get field value
            Console.WriteLine("Field Value : {0} ", pdfForm.GetField("textfield"));
            // ExEnd:GetFieldValue
        }
    }
}