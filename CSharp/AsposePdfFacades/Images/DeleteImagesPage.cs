// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Images
{
    public class DeleteImagesPage
    {
        public static void Run()
        {
            // ExStart:DeleteImagesPage
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Images();
            // Open PDF file
            PdfContentEditor contentEditor = new PdfContentEditor();
            contentEditor.BindPdf(dataDir+ "DeleteImages-Page.pdf");

            // Array of images to be deleted
            int[] imageIndex = new int[] { 1 };

            // Delete the images from the particular page
            contentEditor.DeleteImage(2, imageIndex);

            // Save output PDF
            contentEditor.Save(dataDir+ "DeleteImages-Page_out.pdf");
            // ExEnd:DeleteImagesPage           
            
        }
    }
}