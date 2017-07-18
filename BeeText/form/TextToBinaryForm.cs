using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeeText.form
{
    public partial class TextToBinaryForm : Form
    {
        public TextToBinaryForm()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            string text = entryTextBox.Text;
            string binaryText;

            byte []ascii = Encoding.ASCII.GetBytes(text);

            binaryText = Encoding.UTF8.GetString(ascii);
            binaryTextBox.Text = binaryText;

        }
    }
}
