using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeeText
{
    public partial class BeeTextForm : Form
    {
        public BeeTextForm()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogOpen = new OpenFileDialog();

            openFileDialogOpen.InitialDirectory = "C:\\";
            openFileDialogOpen.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialogOpen.FilterIndex = 2;
            openFileDialogOpen.RestoreDirectory = true;

            if (openFileDialogOpen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new
                   System.IO.StreamReader(openFileDialogOpen.FileName);
                MessageBox.Show(sr.ReadToEnd());
                sr.Close();
            }

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
