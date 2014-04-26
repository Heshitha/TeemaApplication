using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TeemaApplication.Classes
{
    class ShowMessageBox
    {
        public static void ShowError(string Message)
        {
            MessageBox.Show(Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void ShowSuccess(string Message)
        {
            MessageBox.Show(Message, "Successfully Saved!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ShowInformation(string Message)
        {
            MessageBox.Show(Message, "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
