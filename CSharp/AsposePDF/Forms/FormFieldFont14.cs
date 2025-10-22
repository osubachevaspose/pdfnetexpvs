// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
using System.IO;
using Aspose.Pdf.Forms;
using Aspose.Pdf;
using Aspose.Pdf.Text;
using System;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Forms
{
    public class FormFieldFont14
    {
        public static void Run()
        {
            // ExStart:FormFieldFont14
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Forms();

            // Open document
            Document pdfDocument = new Document(dataDir + "FormFieldFont14.pdf");

            // Get particular form field from document
            Aspose.Pdf.Forms.Field field = pdfDocument.Form["textbox1"] as Aspose.Pdf.Forms.Field;

            // Create font object
            Aspose.Pdf.Text.Font font = FontRepository.FindFont("ComicSansMS");

            // Set the font information for form field
            // Field.DefaultAppearance = new Aspose.Pdf.Forms.in.DefaultAppearance(font, 10, System.Drawing.Color.Black);

            dataDir = dataDir + "FormFieldFont14_out.pdf";
            // Save updated document
            pdfDocument.Save(dataDir);
            // ExEnd:FormFieldFont14
            Console.WriteLine("\nForm field font setup successfully.\nFile saved at " + dataDir);
        }
    }
}