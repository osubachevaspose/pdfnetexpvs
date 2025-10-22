// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
using System.IO;
using System;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.StampsWatermarks
{
    public class CountingArtifacts
    {
        public static void Run()
        {
            // ExStart:CountingArtifacts
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_StampsWatermarks();

            // Open document
            Document pdfDocument = new Document( dataDir +  "watermark.pdf");
            int count = 0;
            foreach (Artifact artifact in pdfDocument.Pages[1].Artifacts)
            {
                // If artifact type is watermark, increate the counter
                if (artifact.Subtype == Artifact.ArtifactSubtype.Watermark) count++;
            }
            Console.WriteLine("Page contains " + count + " watermarks");
            // ExEnd:CountingArtifacts            
        }
    }
}