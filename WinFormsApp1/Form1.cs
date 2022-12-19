using LibraryLab13;
using System.Windows.Forms;

namespace WinFormsApp1 {
    public partial class Form1 : Form {

        protected TextFile? OpenTextFile;

        public bool SaveFile = false;

#pragma warning disable CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
        public Form1() {
            OpenTextFile = null;
            InitializeComponent();
        }
#pragma warning restore CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.

        private void FileOpenClick(object sender, EventArgs e) {
            OpenTextFile?.Close();
            State.Text = "Состояние: открытие файла";
            openFileDialog1.Filter = "Текстовый файл(*.txt)|*.txt|Файл rtf(*.rtf)|*.rtf|Все файлы(*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel) {
                return;
            }

            richTextBox1.Clear();
            OpenTextFile = new TextFile(openFileDialog1.FileName);
            //OpenTextFile.FileRead();
            richTextBox1.AppendText(OpenTextFile.Text);
 
            NumWords.Text = "Число слов " + OpenTextFile.WordCount();
            NumChar.Text = "Число знаков: " + richTextBox1.TextLength;
            NumStrings.Text = "Строк: " + richTextBox1.Lines.Length;
        }

        private void FileSaveClick(object sender, EventArgs e) {
            if (OpenTextFile == null) {
                return;
            }
            OpenTextFile.Text = richTextBox1.Text;

            State.Text = "Состояние: сохранение файла";

            OpenTextFile.FileSave();

            SaveFile = true;
        }

        private void SaveFileClick(object sender, EventArgs e) {
            if (OpenTextFile == null) {
                return;
            }

        }
    }
}