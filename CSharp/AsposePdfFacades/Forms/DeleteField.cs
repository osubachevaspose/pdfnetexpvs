// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Forms
{
    public class DeleteField
    {
        public static void Run()
        {
            // ExStart:DeleteField
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Forms();

            FormEditor formEditor = new FormEditor();
            // Open Document
            formEditor.BindPdf(dataDir + "DeleteFormField.pdf");

            // Delete field
            formEditor.RemoveField("textfield");
            // Save updated file
            formEditor.Save( dataDir + "DeleteFormField_out.pdf");
            // ExEnd:DeleteField
        }
    }
}