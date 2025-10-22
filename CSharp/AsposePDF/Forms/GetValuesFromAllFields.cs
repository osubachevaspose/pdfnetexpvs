// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Forms;
using System;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Forms
{
    public class GetValuesFromAllFields
    {
        public static void Run()
        {
            // ExStart:GetValuesFromAllFields
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Forms();

            // Open document
            Document pdfDocument = new Document(dataDir + "GetValuesFromAllFields.pdf");

            // Get values from all fields
            foreach (Field formField in pdfDocument.Form)
            {
                Console.WriteLine("Field Name : {0} ", formField.PartialName);
                Console.WriteLine("Value : {0} ", formField.Value);
            }
            // ExEnd:GetValuesFromAllFields
        }
    }
}