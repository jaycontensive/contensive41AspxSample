﻿
using Contensive.BaseClasses;

namespace Contensive.Samples
{
    public class CreateGuidSample : AddonBaseClass
    {
        public override object Execute(CPBaseClass cp)
        {
            // The buttons.
            string button1 = cp.Html5.Button("button", "Press Me");

            // Add both buttons to the form.
            string innerHtml = "Click here to create a GUID:<br>" +
                button1 + "<br><br>";
            string form = cp.Html5.Form(innerHtml);

            // Check if the user clicked the Surpise1 button.
            if (cp.Doc.GetText("button").Equals("Press Me"))
            {
                // Return the new GUID.
                return form + cp.Utils.CreateGuid();
            }
            // Return the initial form.
            return form;
        }
    }
}