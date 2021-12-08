using System;
using System.Windows.Forms;
using System.Drawing;

namespace PracticeSession
{
    public static class Dialogs
    {
        public static DialogResult InputBox(string title, string promptText, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            var textBoxWidth = 400;
            var textBoxMargin = 22;
            var buttonWidth = 140;

            label.SetBounds(18, 30, textBoxWidth, 26);
            textBox.SetBounds(textBoxMargin, 72, textBoxWidth, 40);
            buttonOk.SetBounds(textBoxWidth + textBoxMargin - (buttonWidth * 2) - 20, 144, buttonWidth, 46);
            buttonCancel.SetBounds(textBoxWidth + textBoxMargin - buttonWidth, 144, buttonWidth, 46);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(textBoxWidth + 2 * textBoxMargin, 214);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
           // form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }
    }
}
