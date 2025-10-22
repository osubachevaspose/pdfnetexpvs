// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
using System.IO;
using Aspose.Pdf;
using System;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.WorkingDocuments
{
    public class GetXMPMetadata
    {
        public static void Run()
        {
            // ExStart:GetXMPMetadata
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_WorkingDocuments();

            // Open document
            Document pdfDocument = new Document(dataDir + "GetXMPMetadata.pdf");

            // Get properties
            Console.WriteLine(pdfDocument.Metadata["xmp:CreateDate"]);
            Console.WriteLine(pdfDocument.Metadata["xmp:Nickname"]);
            Console.WriteLine(pdfDocument.Metadata["xmp:CustomProperty"]);
            // ExEnd:GetXMPMetadata
        }
    }
}