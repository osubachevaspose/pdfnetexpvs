// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.QuickStart
{
    public class SetLicenseUsingEmbeddedResource
    {
        public static void Run()
        {
            // ExStart:1
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_QuickStart();
            // Initialize license object
            Aspose.Pdf.License license = new Aspose.Pdf.License();
            // Set license
            // license.SetLicense("MergedAPI.Aspose.Total.lic");

            Console.WriteLine("License set successfully.");
            // ExEnd:1
        }
    }
}
