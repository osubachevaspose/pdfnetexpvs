// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.WorkingDocuments
{
    public class GetAllFonts
    {
        public static void Run()
        {
            // ExStart:1
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_WorkingDocuments();
            Document doc = new Document(dataDir + "input.pdf");
            Aspose.Pdf.Text.Font[] fonts = doc.FontUtilities.GetAllFonts();
            foreach (Aspose.Pdf.Text.Font font in fonts)
            {
                Console.WriteLine(font.FontName);
            }
            // ExEnd:1
        }
    }
}
