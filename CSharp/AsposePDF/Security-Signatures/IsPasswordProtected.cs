// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;
using System;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.SecuritySignatures
{
    public class IsPasswordProtected
    {
        public static void Run()
        {
            // ExStart:IsPasswordProtected
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_SecuritySignatures();

            // Load the source PDF doucment
            PdfFileInfo fileInfo = new PdfFileInfo(dataDir+ @"IsPasswordProtected.pdf");
            // Determine that source PDF file is Encrypted with password
            bool encrypted = fileInfo.IsEncrypted;
            // MessageBox displays the current status related to PDf encryption
           Console.WriteLine(encrypted.ToString());
            // ExEnd:IsPasswordProtected
            
        }
    }
}