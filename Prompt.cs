using System.Windows.Forms;

public static class Prompt
{
    public static string ShowDialog(string text, string caption, string defaultValue = "")
    {
        Form prompt = new Form()
        {
            Width = 400,
            Height = 200,
            FormBorderStyle = FormBorderStyle.FixedDialog,
            Text = caption,
            StartPosition = FormStartPosition.CenterScreen
        };
        Label lblText = new Label() { Left = 20, Top = 20, Text = text, Width = 350 };
        TextBox txtInput = new TextBox() { Left = 20, Top = 50, Width = 350, Text = defaultValue };
        Button btnOK = new Button() { Text = "OK", Left = 150, Width = 100, Top = 100, DialogResult = DialogResult.OK };
        prompt.Controls.Add(lblText);
        prompt.Controls.Add(txtInput);
        prompt.Controls.Add(btnOK);
        prompt.AcceptButton = btnOK;

        return prompt.ShowDialog() == DialogResult.OK ? txtInput.Text : "";
    }
}
