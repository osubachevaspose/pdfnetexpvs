// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
using System;
using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Forms;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Forms
{
    public class DynamicXFAToAcroForm
    {
        public static void Run()
        {
            // ExStart:DynamicXFAToAcroForm
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Forms();

            // Load dynamic XFA form
            Document document = new Document(dataDir + "DynamicXFAToAcroForm.pdf");

            // Set the form fields type as standard AcroForm
            document.Form.Type = FormType.Standard;

            dataDir = dataDir + "Standard_AcroForm_out.pdf";
            // Save the resultant PDF
            document.Save(dataDir);
            // ExEnd:DynamicXFAToAcroForm
            Console.WriteLine("\nDynamic XFA form converted to standard AcroForm successfully.\nFile saved at " + dataDir);
        }
    }
}