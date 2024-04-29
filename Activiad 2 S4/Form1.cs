using System;
using System.IO;
using System.Windows.Forms;

namespace Activiad_2_S4
{
    public partial class Form1 : Form
    {

        // Ruta del archivo secuencial
        private const string filePath = "sequentialFile.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            // Take the text from textbox
            string textToWrite = txtInput.Text;

            // Open the file in mode append and write the text
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(textToWrite);
            }

            // Clear TextBox
            txtInput.Clear();

            lblOutput.Text = "Text written to file.";
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            // Veroify if the file exists
            if (File.Exists(filePath))
            {
                // Read all the content of the file
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string content = reader.ReadToEnd();
                    lblOutput.Text = "File content:\n" + content;
                }
            }
            else
            {
                lblOutput.Text = "File does not exist.";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Verify if the file exists
            if (File.Exists(filePath))
            {
                //  Delete the file
                File.Delete(filePath);
                lblOutput.Text = "File deleted.";
            }
            else
            {
                lblOutput.Text = "File does not exist.";
            }
        }
    }
}
