// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
using System.IO;
using System;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.LinksActions
{
    public class CreateAppLink
    {
        public static void Run()
        {
            // ExStart:CreateAppLink
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_LinksActions();

            // Open document
            PdfContentEditor contentEditor = new PdfContentEditor();
            contentEditor.BindPdf(dataDir + "CreateApplicationLink.pdf");

            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(100, 100, 200, 200);

            // Create application link
            contentEditor.CreateApplicationLink(rectangle,  dataDir + "test.txt", 1);

            // Save updated PDF
            contentEditor.Save( dataDir + "CreateApplicationLink_out.pdf");
            // ExEnd:CreateAppLink                                 
        }
    }
}