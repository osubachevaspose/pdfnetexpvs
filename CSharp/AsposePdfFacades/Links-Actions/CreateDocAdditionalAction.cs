// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
using System.IO;
using Aspose.Pdf.Facades;
using System;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.LinksActions
{
    public class CreateDocAdditionalAction
    {
        public static void Run()
        {
            // ExStart:CreateDocAdditionalAction
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_LinksActions();

            // Open document
            PdfContentEditor contentEditor = new PdfContentEditor();
            contentEditor.BindPdf(dataDir + "CreateDocumentLink.pdf");

            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(100, 100, 200, 200);

            // Create application link
            contentEditor.AddDocumentAdditionalAction(PdfContentEditor.DocumentClose, "app.alert('Thank you for using Aspose products!');");

            // Save updated PDF
            contentEditor.Save( dataDir + "CreateDocAdditionalAction_out.pdf");
            // ExEnd:CreateDocAdditionalAction
                     
        }
    }
}