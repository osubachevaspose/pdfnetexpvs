// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.DocumentConversion
{
    public class CGMToPDF
    {
        public static void Run()
        {
            // ExStart:CGMToPDF
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_DocumentConversion();

            // Instantiate LoadOption object using CGMLoadOption
            Aspose.Pdf.CgmLoadOptions cgmload = new Aspose.Pdf.CgmLoadOptions();
            // Instantiate Document object
            Document doc = new Document(dataDir + "CGMToPDF.CGM", cgmload);
            // Save the resultant PDF document
            doc.Save(dataDir+ "TECHDRAW_out.pdf");
            // ExEnd:CGMToPDF
        }
    }
}