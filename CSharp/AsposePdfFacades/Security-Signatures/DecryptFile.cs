// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
using System;
using System.IO;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.SecuritySignatures
{
    public class DecryptFile
    {
        public static void Run()
        {
            // ExStart:DecryptFile
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_SecuritySignatures();
            // Create PdfFileSecurity object 
            PdfFileSecurity fileSecurity = new PdfFileSecurity();
            fileSecurity.BindPdf(dataDir + "Decrypt.pdf");
            // Decrypt PDF document
            fileSecurity.DecryptFile("owner");
            fileSecurity.Save(dataDir + "DecryptFile_out.pdf");
            // ExEnd:DecryptFile   
           
        }
    }
}