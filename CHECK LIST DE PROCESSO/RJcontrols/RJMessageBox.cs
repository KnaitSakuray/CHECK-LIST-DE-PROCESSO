using LED_EPL.Forms.Private;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LED_EPL.RJcontrols
{
    public abstract class RJMessageBox
    {




        public static DialogResult Show(string text)
        {//Displays a message box with specified text

            DialogResult result; // Gets or sets the result of the form dialog box.

            // Instantiate the RJMessageForm form using the USING statement to dispose of the form correctly when it has finished its purpose.
            using (var msgForm = new RJMessageForm(text,//Set text message to display
             "Message", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1))//Set other defaults
            {
                result = msgForm.ShowDialog();//Show as modal form            
            }
            return result;//Return Dialog Result            
        }
        public static DialogResult Show(string text, string caption)
        {//Displays a message box with specified text and caption.

            DialogResult result; // Gets or sets the result of the form dialog box.

            // Instantiate the RJMessageForm form using the USING statement to dispose of the form correctly when it has finished its purpose.
            using (var msgForm = new RJMessageForm(text, caption,//Set text message and caption to display
                            MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1))//Set other defaults
            {
                result = msgForm.ShowDialog();//Show as modal form 
            }
            return result;//Return Dialog Result  
        }
        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons)
        {//Displays a message box with specified text, caption, and buttons

            DialogResult result; // Gets or sets the result of the form dialog box.

            // Instantiate the RJMessageForm form using the USING statement to dispose of the form correctly when it has finished its purpose.
            using (var msgForm = new RJMessageForm(text, caption, buttons,//Set text message, caption and buttons to display
                                              MessageBoxIcon.None, MessageBoxDefaultButton.Button1))//Set other defaults
            {
                result = msgForm.ShowDialog();//Show as modal form 
            }
            return result;//Return Dialog Result  
        }
        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {//Displays a message box with specified text, caption, buttons, and icon

            DialogResult result; // Gets or sets the result of the form dialog box.

            // Instantiate the RJMessageForm form using the USING statement to dispose of the form correctly when it has finished its purpose.
            using (var msgForm = new RJMessageForm(text, caption, buttons, icon,//Set text message, caption, buttons and icon to display
                                               MessageBoxDefaultButton.Button1))//Set other defaults
            {
                result = msgForm.ShowDialog(); //Show as modal form           
            }
            return result;//Return Dialog Result  
        }
        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton)
        {//Displays a message box with the specified text, caption, buttons, icon, and default button.

            DialogResult result; // Gets or sets the result of the form dialog box.

            // Instantiate the RJMessageForm form using the USING statement to dispose of the form correctly when it has finished its purpose.
            using (var msgForm = new RJMessageForm(text, caption, buttons, icon, defaultButton))//Set text message, caption, buttons,icon and default button to display
            {
                result = msgForm.ShowDialog();//Show as modal form 
            }
            return result;//Return Dialog Result  
        }
        public static DialogResult Show(IWin32Window owner, string text)
        {//Displays a message box in front of the specified object and with the specified text

            DialogResult result; // Gets or sets the result of the form dialog box.

            // Instantiate the RJMessageForm form using the USING statement to dispose of the form correctly when it has finished its purpose.
            using (var msgForm = new RJMessageForm(text,
                /*->Default Values:*/"Message", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1))
            {
                result = msgForm.ShowDialog(owner);
            }
            return result;
        }
        public static DialogResult Show(IWin32Window owner, string text, string caption)
        {
            DialogResult result;

            using (var msgForm = new RJMessageForm(text, caption,
                /*->Default Values:*/ MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1))
            {
                result = msgForm.ShowDialog(owner);
            }
            return result;
        }
        public static DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons)
        {
            DialogResult result;

            using (var msgForm = new RJMessageForm(text, caption, buttons,
                /*->Default Values:*/ MessageBoxIcon.None, MessageBoxDefaultButton.Button1))
            {
                result = msgForm.ShowDialog(owner);
            }
            return result;
        }
        public static DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            DialogResult result;

            using (var msgForm = new RJMessageForm(text, caption, buttons, icon,
                /*->Default Values:*/MessageBoxDefaultButton.Button1))
            {
                result = msgForm.ShowDialog(owner);
            }
            return result;
        }
        public static DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton)
        {
            DialogResult result;

            using (var msgForm = new RJMessageForm(text, caption, buttons, icon, defaultButton))
            {
                result = msgForm.ShowDialog(owner);
            }
            return result;
        }

    }
}
