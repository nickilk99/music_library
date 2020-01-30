using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Library
{
    /// <summary>
    /// message type enum.
    /// </summary>
    internal enum MESSAGE_TYPE
    {
        SUCCESS,
        FAILURE,
        ADVISORY
    };
    class Message
    {
        /// <summary>
        /// excute method that show message box according different type.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="messageType"></param>
        /// <returns>Dialog Result</returns>
        public static DialogResult show(string message, MESSAGE_TYPE messageType)
        {
            return doShow(message, messageType);
        }

        /// <summary>
        /// show message box according different type.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="messageType"></param>
        /// <returns>Dialog Result</returns>
        private static DialogResult doShow(string message, MESSAGE_TYPE messageType)
        {
            DialogResult dialogResult = DialogResult.None;
            switch(messageType)
            {
                case MESSAGE_TYPE.SUCCESS:
                    dialogResult = MessageBox.Show(message, "PROMPT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case MESSAGE_TYPE.FAILURE:
                    dialogResult = MessageBox.Show(message, "PROMPT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case MESSAGE_TYPE.ADVISORY:
                    dialogResult = MessageBox.Show(message, "PROMPT", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    break;
            }
            return dialogResult;
        }
    }
}
