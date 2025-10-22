// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
using System.IO;
using System;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Graphs
{
    public class AddLineObject
    {
        public static void Run()
        {
            // ExStart:AddLineObject
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Graphs();

            // Create Document instance
            Document doc = new Document();
            // Add page to pages collection of PDF file
            Page page = doc.Pages.Add();
            // Create Graph instance
            Aspose.Pdf.Drawing.Graph graph = new Aspose.Pdf.Drawing.Graph(100.0, 400.0);
            // Add graph object to paragraphs collection of page instance
            page.Paragraphs.Add(graph);
            // Create Rectangle instance
            Aspose.Pdf.Drawing.Line line = new Aspose.Pdf.Drawing.Line(new float[] { 100, 100, 200, 100 });
            // Specify fill color for Graph object
            line.GraphInfo.DashArray = new int[] { 0, 1, 0 };
            line.GraphInfo.DashPhase = 1;
            // Add rectangle object to shapes collection of Graph object
            graph.Shapes.Add(line);
            dataDir = dataDir + "AddLineObject_out.pdf";
            // Save PDF file
            doc.Save(dataDir);
            // ExEnd:AddLineObject
            Console.WriteLine("\nLine object added successfully to pdf.\nFile saved at " + dataDir);
        }
    }
}