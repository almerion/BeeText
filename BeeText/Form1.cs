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
using System.Security;

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
        
        //save as...
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.InitialDirectory = "C:\\";
            saveFileDialog.Filter = "txtfiles (*.txt)|*txt|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string text = textBoxArea.Text;
                string path = (string)saveFileDialog.FileName;

                //check for error(file doesn't exist
                try
                {
                    //creates a new file, writes and closes this file.
                    File.WriteAllText(path, text);
                }
                catch(ArgumentException)
                {
                    MessageBox.Show("path is a zero-length string," +
                        " contains only white space, or contains one or more invalid" +
                        " characters as defined by InvalidPathChars.");
                }
                catch(PathTooLongException)
                {
                    MessageBox.Show("The specified path, file name, " +
                        "or both exceed the system-defined maximum length." +
                        " paths must be less than 248 characters, and file names" +
                        " must be less than 260 characters.");
                }
                catch(DirectoryNotFoundException)
                {
                    MessageBox.Show("The specified path is invalid.");
                }
                catch(IOException)
                {
                    MessageBox.Show("An I/O error occurred while opening the file.");
                }
                catch(NotSupportedException)
                {
                    MessageBox.Show("path is in an invalid format.");
                }
                catch(SecurityException)
                {
                    MessageBox.Show("The caller does not have the required permission.");
                }   
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
