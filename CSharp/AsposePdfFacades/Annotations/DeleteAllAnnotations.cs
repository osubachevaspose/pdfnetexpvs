// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Annotations
{
    public class DeleteAllAnnotations
    {
        public static void Run()
        {
            // ExStart:DeleteAllAnnotations
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Annotations();
            // Open document
            PdfAnnotationEditor annotationEditor = new PdfAnnotationEditor();
            annotationEditor.BindPdf(dataDir+ "DeleteAllAnnotations.pdf");
            // Delete all annoations
            annotationEditor.DeleteAnnotations();
            // Save updated PDF
            annotationEditor.Save(dataDir+ "DeleteAllAnnotations_out.pdf");
            // ExEnd:DeleteAllAnnotations
        }
    }
}