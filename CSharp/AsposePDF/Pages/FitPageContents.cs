// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Pages
{
    public class FitPageContents
    {
        public static void Run()
        {
            // ExStart:FitPageContents
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Pages();

            Document doc = new Document(dataDir + "input.pdf");
            foreach (Page page in doc.Pages)
            {
                Rectangle r = page.MediaBox;
                // New height the same
                double newHeight = r.Height;
                // New width is expanded proportionally to make orientation landscape
                // (we assume that previous orientation is portrait)
                double newWidth = r.Height * r.Height / r.Width;

            }          
            // ExEnd:FitPageContents
            
        }
    }
}