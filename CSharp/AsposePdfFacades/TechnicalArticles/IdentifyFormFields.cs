// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
using System.IO;
using System;
using Aspose.Pdf.Facades;
using Aspose.Pdf.Annotations;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.TechnicalArticles
{
    public class IdentifyFormFields
    {
        public static void Run()
        {
            // ExStart:IdentifyFormFields
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_TechnicalArticles();

            // First a input pdf file should be assigned
            Aspose.Pdf.Facades.Form form = new Aspose.Pdf.Facades.Form(dataDir + "FilledForm.pdf");
            // Get all field names
            String[] allfields = form.FieldNames;
            // Create an array which will hold the location coordinates of Form fields
            System.Drawing.Rectangle[] box = new System.Drawing.Rectangle[allfields.Length];
            for (int i = 0; i < allfields.Length; i++)
            {
                // Get the appearance attributes of each field, consequtively
                FormFieldFacade facade = form.GetFieldFacade(allfields[i]);
                // Box in FormFieldFacade class holds field's location.
                box[i] = facade.Box;
            }
            form.Save(dataDir + "IdentifyFormFields_1_out.pdf");

            Document doc = new Document(dataDir + "FilledForm - 2.pdf");
            // Now we need to add a textfield just upon the original one
            FormEditor editor = new FormEditor(doc);
            for (int i = 0; i < allfields.Length; i++)
            {
                // Add text field beneath every existing form field
                editor.AddField(FieldType.Text, "TextField" + i, allfields[i], 1, box[i].Left, box[i].Top, box[i].Left + 50, box[i].Top + 10);
            }
            // Close the document
            editor.Save(dataDir + "IdentifyFormFields_out.pdf");
            // ExEnd:IdentifyFormFields                      
        }
    }
}