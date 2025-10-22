// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Text
{
    public class ReplaceTextPage
    {
        public static void Run()
        {
            // ExStart:ReplaceTextPage
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Text();
            // Open input PDF
            PdfContentEditor pdfContentEditor = new PdfContentEditor();
            pdfContentEditor.BindPdf(dataDir+ "ReplaceText-Page.pdf");
            // Replace text on all pages
            pdfContentEditor.ReplaceText("Hello", 1, "World");
            // Save output PDF
            pdfContentEditor.Save(dataDir + "ReplaceTextPage_out.pdf");
            // ExEnd:ReplaceTextPage            
        }
    }
}