using System.Drawing;
using System.Windows.Forms;

namespace Hospital
{
    public static class Placeholder
    {
        public static void SetPlaceholder(TextBox textBox, string placeholderText)
        {
            Color placeholderColor = Color.Gray;
            Color defaultColor = textBox.ForeColor;
            char originalPasswordChar = textBox.PasswordChar;

            void ShowPlaceholder()
            {
                textBox.Text = placeholderText;
                textBox.ForeColor = placeholderColor;
                textBox.PasswordChar = '\0'; 
            }

            void HidePlaceholder()
            {
                textBox.Text = "";
                textBox.ForeColor = defaultColor;
                textBox.PasswordChar = originalPasswordChar; 
            }

            ShowPlaceholder();

            textBox.Enter += (sender, e) =>
            {
                if (textBox.Text == placeholderText)
                {
                    HidePlaceholder();
                }
            };

            textBox.Leave += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    ShowPlaceholder();
                }
            };
        }
    }
}
