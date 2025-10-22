// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
using Aspose.Pdf.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Text
{
    public class AccessTextFragementAndTextSegmentElementsFromXMLFile
    {
        public static void Run()
        {
            //ExStart: AccessTextFragementAndTextSegmentElementsFromXMLFile
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Text();

            string inXml = "40014.xml";
            string outFile = "40014_out.pdf";

            Document doc = new Document();
            doc.BindXml(dataDir + inXml);

            Page page = (Page)doc.GetObjectById("mainSection");

            TextSegment segment = (TextSegment)doc.GetObjectById("boldHtml");
            segment = (TextSegment)doc.GetObjectById("strongHtml");
            doc.Save(dataDir + outFile);
            //ExEnd: AccessTextFragementAndTextSegmentElementsFromXMLFile
        }
    }
}
