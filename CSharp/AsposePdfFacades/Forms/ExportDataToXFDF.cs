// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Forms
{
    public class ExportDataToXFDF
    {
        public static void Run()
        {
            // ExStart:ExportDataToXFDF
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Forms();

            Aspose.Pdf.Facades.Form form = new Aspose.Pdf.Facades.Form();
            // Open Document
            form.BindPdf(dataDir + "input.pdf");

            // Create xfdf file.
            System.IO.FileStream xfdfOutputStream = new FileStream("student1.xfdf", FileMode.Create);

            // Export data
            form.ExportXfdf(xfdfOutputStream);

            // Close file stream
            xfdfOutputStream.Close();

            // Save updated document
            form.Save(dataDir + "ExportDataToXFDF_out.pdf");
            // ExEnd:ExportDataToXFDF
        }        
    }
}