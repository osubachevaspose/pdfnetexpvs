// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;
using System.Drawing;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Annotations
{
    public class AddFreeTextAnnotation
    {
        public static void Run()
        {
            // ExStart:AddFreeTextAnnotation
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Annotations();
            // Open document
            PdfContentEditor contentEditor = new PdfContentEditor();
            contentEditor.BindPdf(dataDir+ "AddFreeTextAnnotation.pdf");
            // Create rectangle
            System.Drawing.Rectangle rect = new System.Drawing.Rectangle(50, 50, 100, 100);
            // Create annotation
            contentEditor.CreateFreeText(rect, "Sample content", 1);
            // Save updated PDF file
            contentEditor.Save(dataDir+ "AddFreeTextAnnotation_out.pdf");
            // ExEnd:AddFreeTextAnnotation            
        }
    }
}