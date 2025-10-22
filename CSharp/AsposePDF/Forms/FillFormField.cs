// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
using System;
using System.IO;
using Aspose.Pdf.Forms;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Forms
{
    public class FillFormField
    {
        public static void Run()
        {
            // ExStart:FillFormField
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Forms();

            // Open document
            Document pdfDocument = new Document(dataDir + "FillFormField.pdf");

            // Get a field
            TextBoxField textBoxField = pdfDocument.Form["textbox1"] as TextBoxField;
            
            // Modify field value
            textBoxField.Value = "Value to be filled in the field";
            dataDir = dataDir + "FillFormField_out.pdf";
            // Save updated document
            pdfDocument.Save(dataDir);
            // ExEnd:FillFormField
            Console.WriteLine("\nForm field filled successfully.\nFile saved at " + dataDir);
        }
    }
}