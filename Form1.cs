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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab8._1
{
    public partial class Form1 : Form
    {
        private string filePath;
        private FileSystemWatcher fileWatcher;
        public Form1()
        {
            InitializeComponent();
            fileWatcher = new FileSystemWatcher();
            fileWatcher.NotifyFilter = NotifyFilters.LastWrite;
            fileWatcher.Changed += FileWatcher_Changed;
        }
        private void FileWatcher_Changed(object sender, FileSystemEventArgs e)
        {
            if (e.FullPath == filePath)
            {
                Invoke((MethodInvoker)delegate
                {
                    ReloadFile();
                });
            }
        }
        private void OpenFile(string path)
        {
            filePath = path;
            fileWatcher.Path = Path.GetDirectoryName(path);
            fileWatcher.Filter = Path.GetFileName(path);
            fileWatcher.EnableRaisingEvents = true;

            ReloadFile();
        }
        private Encoding GetSelectedEncoding()
        {
            if (utf8RadioButton.Checked)
            {
                return Encoding.UTF8;
            }
            else if (utf16RadioButton.Checked)
            {
                return Encoding.Unicode;
            }
            else if (ansiRadioButton.Checked)
            {
                return Encoding.Default;
            }
            else if (utf32RadioButton.Checked)
            {
                return Encoding.UTF32;
            }
            else
            {
                return Encoding.Default;
            }
        }

        private void ReloadFile()
        {
            richTextBox1.Text = File.ReadAllText(filePath);
        }

        private void SaveFile()
        {
            if (!string.IsNullOrEmpty(filePath))
            {
                Encoding selectedEncoding = GetSelectedEncoding();

                File.WriteAllText(filePath, richTextBox1.Text, selectedEncoding);
            }
            else
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = saveFileDialog.FileName;

                    Encoding selectedEncoding = GetSelectedEncoding();

                    File.WriteAllText(filePath, richTextBox1.Text, selectedEncoding);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                OpenFile(openFileDialog1.FileName);
            }
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(filePath))
            {
                SaveFile();
            }
            else
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = saveFileDialog.FileName;
                    SaveFile();
                }
            }
        }

        private void utf16RadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
