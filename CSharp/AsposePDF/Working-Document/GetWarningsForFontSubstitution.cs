// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Working_Document
{
    public class GetWarningsForFontSubstitution
    {
        public static void Run()
        {
            //ExStart: GetWarningsForFontSubstitution
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_WorkingDocuments();

            Document doc = new Document(dataDir + "input.pdf");

            doc.FontSubstitution += new Document.FontSubstitutionHandler(OnFontSubstitution);
            //ExEnd: GetWarningsForFontSubstitution
        }

        static void OnFontSubstitution(Aspose.Pdf.Text.Font oldFont, Aspose.Pdf.Text.Font newFont)
        {
            //ExStart: OnFontSubstitution
            Console.WriteLine(string.Format("Font '{0}' was substituted with another font '{1}'",
            oldFont.FontName, newFont.FontName));
            //ExEnd: OnFontSubstitution
        }
    }
}
