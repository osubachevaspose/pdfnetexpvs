// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Forms
{
    public class ImportDataFromXML
    {
        public static void Run()
        {
            // ExStart:ImportDataFromXML
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Forms();

            // Open document
            Aspose.Pdf.Facades.Form form = new Aspose.Pdf.Facades.Form();        

            // Open xml file.
            System.IO.FileStream xmlInputStream = new FileStream(dataDir + "input.xml", FileMode.Open);

            // Import data
            form.ImportXml(xmlInputStream);

            // Close file stream
            xmlInputStream.Close();

            // Save updated document
            form.Save(dataDir + "ImportDataFromXML_out.pdf");
            // ExEnd:ImportDataFromXML
        }        
    }
}