using LibraryLab13;
using System.Diagnostics;
using System.Xml.Serialization;
using static System.Net.Mime.MediaTypeNames;

namespace WinFormsApp1 {
    public partial class Form1 : Form {

        protected TextFile? OpenTextFile;
        private bool _saveFile = false;

        public Form1() {
            OpenTextFile = null;
            InitializeComponent();
        }

        private void FileOpenClick(object sender, EventArgs e) {
            State.Text = "Состояние: открытие файла";
            openFileDialog1.Filter = "Текстовый файл(*.txt)|*.txt|Файл rtf(*.rtf)|*.rtf|Все файлы(*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            

            richTextBox1.Clear();
            OpenTextFile = new TextFile(openFileDialog1.FileName);
            //OpenTextFile.FileRead();
            richTextBox1.AppendText(OpenTextFile.Text);

            Debug.WriteLine(OpenTextFile.WordCount());

            NumWords.Text = "Число слов " + OpenTextFile.WordCount();
            NumChar.Text = "Число знаков: " + richTextBox1.TextLength;
            NumStrings.Text = "Строк: " + richTextBox1.Lines.Length;
        }

        private void FileSaveClick(object sender, EventArgs e) {
            if (OpenTextFile == null) {
                ErrorOutput(
                    "Файл не открыт.\n" +
                    "откройте файл чтобы сохранить его\n" +
                    "или сохраните файл через функцию \"Сохранить как\""
                );
                return;
            }

            State.Text = "Состояние: сохранение файла";

            if (!File.Exists(OpenTextFile.FilePath)) {
                saveFileDialog1.Filter = "Текстовый файл(*.txt)|*.txt|Файл rtf(*.rtf)|*.rtf|Все файлы(*.*)|*.*";
                saveFileDialog1.Title = "Сохранить";

                OpenTextFile = new TextFile(saveFileDialog1.FileName);
            }
            OpenTextFile.Text = richTextBox1.Text;
            OpenTextFile.FileSave();
            _saveFile = true;
        }

        private void FileSaveAsClick(object sender, EventArgs e) {
            /*if (OpenTextFile == null) {
                ErrorOutput("Файл не открыт.\n" +
                    "откройте файл чтобы сохранить его");
            }*/
            //OpenTextFile.Text = richTextBox1.Text;
            State.Text = "Состояние: сохранение файла";
            saveFileDialog1.Filter = "Текстовый файл(*.txt)|*.txt|Файл rtf(*.rtf)|*.rtf|Все файлы(*.*)|*.*";
            saveFileDialog1.Title = "Сохранить как..";

            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            

            TextFile OpenTextFile2 = new(saveFileDialog1.FileName);
            OpenTextFile2.Text = richTextBox1.Text;
            OpenTextFile2.FileSave();

            _saveFile = true;
        }

        private void PrintPageClick(object sender, EventArgs e) {
            if (OpenTextFile == null) {
                ErrorOutput("Файл не открыт");
                return;
            }
            if (string.IsNullOrEmpty(OpenTextFile.Text)) {
                ErrorOutput("Файл пустой");
                return;
            }

            State.Text = "Состояние: Распечатка файла";

            try {
                OpenTextFile.PrintPage();
                State.Text = "Состояние: конец печати";
            } catch (Exception ex) {
                ErrorOutput(ex.Message);
                State.Text = "Состояние: Печать сорвана";
            }
        }

        private void ErrorOutput(string text) {
            MessageBox.Show(
                text,
                "Ты чего наделал?",
                MessageBoxButtons.OK,
                MessageBoxIcon.Stop,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly
            );
        }

        private void SearchFilesTheDirectoryClick(object sender, EventArgs e) {
            Form2 form2 = new() {
                Owner = this
            };
            form2.ShowDialog();
            if (string.IsNullOrEmpty(form2.DataBuf)) {
                return;
            }

            richTextBox1.Clear();
            OpenTextFile = new TextFile(form2.DataBuf);

            OpenTextFile.FileRead();
            richTextBox1.AppendText(OpenTextFile.Text);

            NumWords.Text = "Число слов " + OpenTextFile.WordCount();
            NumChar.Text = "Число знаков: " + richTextBox1.TextLength;
            NumStrings.Text = "Строк: " + richTextBox1.Lines.Length;
        }

        private void показатьСкрытьToolStripMenuItem_Click(object sender, EventArgs e) {
            if (toolStrip1.Visible) {
                toolStrip1.Hide();
            } else {
                toolStrip1.Show();
            }
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e) {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK) {
                richTextBox1.ForeColor = colorDialog.Color;
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e) {
            Form3 form3 = new();
            form3.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void toolStripButton3_Click(object sender, EventArgs e) {
            richTextBox1.Clear();
        }

        private void вариантToolStripMenuItem_Click(object sender, EventArgs e) {
            if (OpenTextFile == null) {
                ErrorOutput("Файл не открыт");
                return;
            }
            /*InfoShow("Слова с ");*/
        }

        private void InfoShow( string title, string text) {
            MessageBox.Show(
                text,
                title,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly
            );
        }

        
    }
}