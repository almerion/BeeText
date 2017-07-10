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

        private void fullScreenToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Maximized;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.AllowFullOpen = false;
            colorDialog.ShowHelp = false;
            colorDialog.Color = textBoxArea.ForeColor;
            textBoxArea.Focus();

            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxArea.ForeColor = colorDialog.Color;
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowColor = true;

            if(fontDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxArea.Font = fontDialog.Font;
                textBoxArea.ForeColor = fontDialog.Color;
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(textBoxArea.SelectedText.Length > 0) { textBoxArea.Cut(); }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if(textBoxArea.SelectedText.Length > 0) { textBoxArea.Copy(); }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
            {
                if(textBoxArea.SelectedText.Length > 0)
                {
                    textBoxArea.SelectionStart = textBoxArea.SelectionStart + textBoxArea.SelectionLength;
                }

                textBoxArea.Paste();
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBoxArea.CanUndo) { textBoxArea.Undo(); textBoxArea.ClearUndo(); }
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxArea.SelectAll();
            textBoxArea.Focus();
        }

        private void matrixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //textbox and text 
            textBoxArea.BackColor = Color.Black;
            textBoxArea.ForeColor = Color.Green;

            
        }

        private void nightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxArea.BackColor = Color.Black;
            textBoxArea.ForeColor = Color.White;
        }

        private void germanToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frenchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //beetext
            this.fullScreenToolStripMenuItem1.Text = "Plein écran";
            this.searchToolStripMenuItem.Text = "Chercher";
            //file
            this.fileToolStripMenuItem.Text = "Fichier";
            this.newToolStripMenuItem.Text = "Nouveau";
            this.openToolStripMenuItem.Text = "Ouvrir";
            this.openFileLocationToolStripMenuItem.Text = "Lieu de fichier ouvert";
            this.saveToolStripMenuItem.Text = "Enregistrer";
            this.saveAsToolStripMenuItem.Text = "Enregistrer sous";
            this.renameToolStripMenuItem.Text = "Rebaptiser";
            this.closeToolStripMenuItem.Text = "Fermer";
            this.deleteFileToolStripMenuItem.Text = "Supprimer Le Fichier";
            //text
            this.textToolStripMenuItem.Text = "Texte";
            this.colorToolStripMenuItem.Text = "Couleur";
            this.fontToolStripMenuItem.Text = "Police De Caractère";
            //edit
            this.editToolStripMenuItem.Text = "Modifier";
            this.undoToolStripMenuItem.Text = "Annuler";
            this.cutToolStripMenuItem.Text = "Couper";
            this.copyToolStripMenuItem.Text = "Copie";
            this.pasteToolStripMenuItem.Text = "Coller";
            this.deleteToolStripMenuItem.Text = "Effacer";
            this.selectAllToolStripMenuItem.Text = "Tout Sélectionner";
            //settings
            this.settingsToolStripMenuItem.Text = "Paramètres";
            this.languageToolStripMenuItem.Text = "Les langues";
            this.themesToolStripMenuItem.Text = "Thèmes";
            this.encodingToolStripMenuItem.Text = "Codage";
            //about
            this.aboutToolStripMenuItem.Text = "Sur";
            
        }
    }
}
