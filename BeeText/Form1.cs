using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BeeText
{
    public partial class BeeTextForm : Form
    {
        public BeeTextForm()
        {
            InitializeComponent();
        }
        //
        //menu bar
        //

        //open
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "C:\\";
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog.FileName);
                textBoxArea.Text = sr.ReadToEnd();
                sr.Close();
            }

        }

        //new file
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog newFileDialog = new OpenFileDialog();

            newFileDialog.InitialDirectory = "C:\\";
            newFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            newFileDialog.FilterIndex = 2;
            newFileDialog.RestoreDirectory = true;

            if(newFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader streamReader = new StreamReader(newFileDialog.FileName);
                streamReader.Close();
            }
        }
    }
}
