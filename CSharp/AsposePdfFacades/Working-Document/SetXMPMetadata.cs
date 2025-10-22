// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.WorkingDocument
{
    public class SetXMPMetadata
    {
        public static void Run()
        {
            // ExStart:SetXMPMetadata
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_WorkingDocuments();

            // Create PdfXmpMetadata object
            PdfXmpMetadata xmpMetaData = new PdfXmpMetadata();

            // Bind pdf file to the object
            xmpMetaData.BindPdf(dataDir+ "SetXMPMetadata.pdf");

            // Add create date
            xmpMetaData.Add(DefaultMetadataProperties.CreateDate, System.DateTime.Now.ToString());

            // Change meta data date
            xmpMetaData[DefaultMetadataProperties.MetadataDate] = System.DateTime.Now.ToString();

            // Add creator tool
            xmpMetaData.Add(DefaultMetadataProperties.CreatorTool, "Creator tool name");

            // Remove modify date
            xmpMetaData.Remove(DefaultMetadataProperties.ModifyDate);

            // Add user defined property
            // Step #1: register namespace prefix and URI
            xmpMetaData.RegisterNamespaceURI("customNamespace", "http:// Www.customNameSpaces.com/ns/");
            // Step #2: add user property with the prefix
            xmpMetaData.Add("customNamespace:UserPropertyName", "UserPropertyValue");

            // Change user defined property
            xmpMetaData["customNamespace:UserPropertyName"] = "UserPropertyValue2";

            // Save xmp meta data in the pdf file
            xmpMetaData.Save(dataDir+ "SetXMPMetadata_out.pdf");

            // Close the object
            xmpMetaData.Close();
            // ExEnd:SetXMPMetadata
        }
    }
}