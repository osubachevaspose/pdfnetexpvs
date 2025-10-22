// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
using System.IO;
using Ionic.Zip;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.QuickStart
{
    public class SecureLicense
    {
        public static void Run()
        {
            // ExStart:1
            using (Stream zip = new SecureLicense().GetType().Assembly.GetManifestResourceStream("Aspose.Total.lic.zip"))
            {
                using (ZipFile zf = ZipFile.Read(zip))
                {
                    MemoryStream ms = new MemoryStream();
                    ZipEntry e = zf["Aspose.Total.lic"];
                    e.ExtractWithPassword(ms, "test");
                    ms.Position = 0;
                }
            }
            // ExEnd:1
        }
    }
}
