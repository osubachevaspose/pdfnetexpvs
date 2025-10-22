// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
using Aspose.Pdf.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Text
{
    public class SetHTMLStringFormatting
    {
        public static void Run()
        {
            // ExStart:SetHTMLStringFormatting
            HtmlFragment html = new HtmlFragment("some text");
            html.TextState = new TextState();
            html.TextState.Font = FontRepository.FindFont("Calibri");
            // ExEnd:SetHTMLStringFormatting

        }
    }
}
